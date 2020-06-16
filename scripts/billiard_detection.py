import numpy as np
import os
import six.moves.urllib as urllib
import sys
import tarfile
import tensorflow as tf
import zipfile
import cv2

from collections import defaultdict
from io import StringIO
from matplotlib import pyplot as plt
from PIL import Image
from object_detection.utils import label_map_util
from object_detection.utils import visualization_utils as vis_util

# Define the video stream
# Change only if you have more than one webcams
cap = cv2.VideoCapture('billiard_test_data/films/game_1.mp4')

#test_img = cv2.imread('billiard_test_data/imgs/multi_1.png')

# Model directory
MODEL_NAME = 'model'

# Path to frozen detection graph. This is the actual model that is used for the object detection.
PATH_TO_CKPT = MODEL_NAME  + '/saved_model.pb'

# List of the strings that is used to add correct label for each box.
PATH_TO_LABELS = os.path.join('annotations', 'label_map.pbtxt')

# Number of classes to detect
NUM_CLASSES = 17

# White ball id
BWHITE = 16

# Detection gone counter for every ball
frames_gone = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

# Load a (frozen) Tensorflow model into memory.
detection_graph = tf.Graph()
with detection_graph.as_default():
    od_graph_def = tf.compat.v1.GraphDef()
    with tf.io.gfile.GFile(PATH_TO_CKPT, 'rb') as fid:
        serialized_graph = fid.read()
        od_graph_def.ParseFromString(serialized_graph)
        tf.import_graph_def(od_graph_def, name='')


# Loading label map
# Label maps map indices to category names, so that when our convolution network predicts `5`, we know that this corresponds to `airplane`.  Here we use internal utility functions, but anything that returns a dictionary mapping integers to appropriate string labels would be fine
label_map = label_map_util.load_labelmap(PATH_TO_LABELS)
categories = label_map_util.convert_label_map_to_categories(
    label_map, max_num_classes=NUM_CLASSES, use_display_name=True)
category_index = label_map_util.create_category_index(categories)


# Helper code
def load_image_into_numpy_array(image):
    (im_width, im_height) = image.size
    return np.array(image.getdata()).reshape(
        (im_height, im_width, 3)).astype(np.uint8)


class DetectedObj:
    def __init__(self, cls=None, coords=None, score=None):
        self.cls = cls
        self.coords = coords
        self.score = score
        self.centerX = None
        self.centerY = None

class Player:
	def __init__(self, number, name, balls):
		self.name = name
		self.balls = balls
		self.number = number

class GameState:
	def __init__(self, player1='Player1', player2='Player2'):
		# Initially all balls are in play
		self.balls = [ 1, 2, 3, 4, 5, 6, 7, 8, 9,
					10, 11, 12, 13, 14, 15, BWHITE]
		self.player1 = Player(1, player1, [1, 2, 3, 4, 5, 6, 7])
		self.player2 = Player(2, player2, [9, 10, 11, 12, 13, 14, 15])
		self.turn = 1

	def ball_fall(self, ball):

		player = self.player1 if turn == 1 else self.player2

		# Check if it is white ball
		if ball == BWHITE:
			print('Faul caused by player: ', player.name, '! End of the turn.')
			self.next_turn()
			return

		try:
			self.balls.remove(ball)
		except ValueError:
			print('Ball ', ball, ' is not in game anymore.')
			return


		# Decide if that was a score
		self.score(player, ball)

	def score(self, player, ball):
		if ball in player.balls:
			print(self.player1, ' has scored!')

		elif ball == 8:
			if self.is_player_winning(player):
				print(player.name, ' has won!')
			else:
				print(player.name, ' has lost!')

		else:
			print('Bad shot! Opposing player scores. End of the current player\'s turn.')
			self.next_turn()

	def next_turn(self):
		self.turn = 1 if self.turn != 1 else 2

	def is_player_winning(self, player):

		for ball in self.balls:
			if ball in player.balls:
				return false

		return true


def detect_collision(detection_data, objects_to_check,
                     max_distance=0.01, detection_treshold=0.5):
    if detection_data['num_detections'] < 2:
        return False

    if objects_to_check[0] == objects_to_check[1]:
        raise ValueError()

    obj1 = DetectedObj(objects_to_check[0])
    obj2 = DetectedObj(objects_to_check[1])

    for i in range(int(detection_data['num_detections'])):
        if detection_data['scores'][i] < detection_treshold:
            break
        if obj1.coords is None and detection_data['classes'][i] == obj1.cls:
            obj1.coords = detection_data['boxes'][i]
        if obj2.coords is None and detection_data['classes'][i] == obj2.cls:
            obj2.coords = detection_data['boxes'][i]
        if obj1.coords is not None and obj2.coords is not None:
            break

    if obj1.coords is None or obj2.coords is None:
        return False

    # coords: ymin, xmin, ymax, xmax
    # these are normalized 0-1 values
    obj1.centerX = (obj1.coords[1] + obj1.coords[3]) / 2
    obj1.centerY = (obj1.coords[0] + obj1.coords[2]) / 2
    obj2.centerX = (obj2.coords[1] + obj2.coords[3]) / 2
    obj2.centerY = (obj2.coords[0] + obj2.coords[2]) / 2

    euclidian_distance = ((obj1.centerX - obj2.centerX) **
                          2 + (obj1.centerY - obj2.centerY) ** 2) ** (1/2)
    if euclidian_distance <= max_distance:
        return True
    return False

def detect_fall(detection_data, game_state, frames_gone_treshold=3):
	for ball in game_state.balls:

		if detect_collision(detection_data, [ball, ball]):
			frames_gone[ball - 1] = -1
		else:
			frames_gone[ball - 1] = frames_gone[ball - 1] - 1


		if detect_collision(detection_data, [16, ball]):
			frames_gone[ball - 1] = frames_gone_treshold

		if frames_gone[ball - 1] == 0:
			game_state.ball_fall(ball)



game_state = GameState()
# Detection
with detection_graph.as_default():
    with tf.compat.v1.Session(graph=detection_graph) as sess:
        while True:
            # Read frame from camera
            ret, image_np = cap.read()
            #image_np = test_img
            # Expand dimensions since the model expects images to have shape: [1, None, None, 3]
            image_np_expanded = np.expand_dims(image_np, axis=0)
            # Extract image tensor
            image_tensor = detection_graph.get_tensor_by_name('image_tensor:0')
            # Extract detection boxes
            boxes = detection_graph.get_tensor_by_name('detection_boxes:0')
            # Extract detection scores
            scores = detection_graph.get_tensor_by_name('detection_scores:0')
            # Extract detection classes
            classes = detection_graph.get_tensor_by_name('detection_classes:0')            # Extract number of detections
            num_detections = detection_graph.get_tensor_by_name(
                'num_detections:0')
            # Actual detection.
            (boxes, scores, classes, num_detections) = sess.run(
                [boxes, scores, classes, num_detections],
                feed_dict={image_tensor: image_np_expanded})

            # Detect collision
            img_objs_data = {
                'boxes': boxes[0],
                'scores': scores[0],
                'classes': classes[0],
                'num_detections': num_detections[0]
            }

            detect_fall(img_objs_data, game_state, 30)
            objects_to_check = [2, 9]  # b2, b9
            collision_present = detect_collision(img_objs_data, objects_to_check, detection_treshold=0)

            # Visualization of the results of a detection.
            vis_util.visualize_boxes_and_labels_on_image_array(
                image_np,
                np.squeeze(boxes),
                np.squeeze(classes).astype(np.int32),
                # np.squeeze(scores),
                None,
                category_index,
                use_normalized_coordinates=True,
                line_thickness=8)

            # Display output
            cv2.imshow('object detection', cv2.resize(image_np, (800, 600)))

            if cv2.waitKey(25) & 0xFF == ord('q'):
                cv2.destroyAllWindows()
                break
