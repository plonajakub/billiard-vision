import os
import cv2
import io
import numpy as np
import tensorflow as tf

from matplotlib import pyplot as plt
from object_detection.utils import label_map_util
from object_detection.utils import visualization_utils as vis_util


# Define the video stream
cap = cv2.VideoCapture('billiard_test_data/films/game_1.mp4')

# Model directory
MODEL_PATH = os.path.join('model')

# List of the strings that is used to add correct label for each box.
PATH_TO_LABELS = os.path.join(
    'annotations', 'billiard-17-classes-label-map.pbtxt')

# Number of classes to detect
NUM_CLASSES = 17

# White ball id
BWHITE = 16

# Detection gone counter for every ball
frames_gone = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]

# Loading label map
# Label maps map indices to category names, so that when our convolution network predicts `5`, we know that this corresponds to `airplane`.  Here we use internal utility functions, but anything that returns a dictionary mapping integers to appropriate string labels would be fine
label_map = label_map_util.load_labelmap(PATH_TO_LABELS)
categories = label_map_util.convert_label_map_to_categories(
    label_map, max_num_classes=NUM_CLASSES, use_display_name=True)
category_index = label_map_util.create_category_index(categories)


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



# Control how often visualization is generated
frame_idx = 1
show_image_step = 1

# Game state controlling class
game_state = GameState()

# Detection
with tf.Session(graph=tf.Graph()) as sess:
    tf.saved_model.loader.load(sess, ["serve"], MODEL_PATH)
    detection_graph = tf.get_default_graph()
    while True:
        # Read frame from camera
        ret, image_np = cap.read()
        is_success, buffer = cv2.imencode(".png", image_np)
        img_io = io.BytesIO(buffer)
        image_raw = img_io.read()
        # Extract image tensor
        image_tensor = detection_graph.get_tensor_by_name(
            'encoded_image_string_tensor:0')
        image_key = detection_graph.get_tensor_by_name('key:0')
        # Extract detection boxes
        boxes = detection_graph.get_tensor_by_name('detection_boxes:0')
        # Extract detection scores
        scores = detection_graph.get_tensor_by_name('detection_scores:0')
        # Extract detection classes
        classes = detection_graph.get_tensor_by_name('detection_classes:0')
        # Extract number of detections
        num_detections = detection_graph.get_tensor_by_name(
            'num_detections:0')
        # Actual detection.
        (boxes, scores, classes, num_detections) = sess.run(
            [boxes, scores, classes, num_detections],
            feed_dict={image_tensor: [image_raw], image_key: ['no_key']})

        # Detect collision
        img_objs_data = {
             'boxes': boxes,
             'scores': scores,
             'classes': classes,
             'num_detections': num_detections
         }
        # objects_to_check = [2, 9]  # b2, b9
        # collision_present = detect_collision(
        #     img_objs_data, objects_to_check, detection_treshold=0)
        detect_fall(img_objs_data, game_state, 30)

        if (frame_idx >= show_image_step):
            # Visualization of the results of a detection.
            vis_util.visualize_boxes_and_labels_on_image_array(
                image_np,
                np.squeeze(boxes),
                np.squeeze(classes).astype(np.int32),
                np.squeeze(scores),
                category_index,
                use_normalized_coordinates=True,
                min_score_thresh=0.2)

            # Display output
            cv2.imshow('Image object detection',
                       cv2.resize(image_np, (1720, 880)))

            if cv2.waitKey(25) & 0xFF == ord('q'):
                cv2.destroyAllWindows()
                break
            frame_idx = 0
        frame_idx += 1
