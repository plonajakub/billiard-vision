import tensorflow as tf
import pandas as pd
from progress.bar import Bar

from object_detection.utils import dataset_util

# TODO export as script arguments
DATA_ROOT_PATH = '/home/jakub/app_projects/rpo/data/test/processed/'
IMG_PATH = DATA_ROOT_PATH + 'dataset/'
CSV_PATH = DATA_ROOT_PATH + 'description.csv'
TFRECORD_PATH = DATA_ROOT_PATH + 'tfrecord/billard-vision.tfr'

# TODO read from protobuf (.prbtxt)
classes_id = {'b1': 1, 'b2': 2, 'b3': 3, 'b4': 4, 'b5': 5, 'b6': 6, 'b7': 7, 'b8': 8,
              'b9': 9, 'b10': 10, 'b11': 11, 'b12': 12, 'b13': 13, 'b14': 14, 'b15': 15,
              'bw': 16, 'h': 17}


class Example:

    def __init__(self, filename, img_format, height, width):
        self.filename = filename
        self.img_format = img_format
        self.height = height
        self.width = width
        self.xmins = []
        self.ymins = []
        self.xmaxs = []
        self.ymaxs = []
        self.classes_text = []
        self.classes = []


def create_tf_example(example):
    height = example.height
    width = example.width
    filename = example.filename
    encoded_image_data = None
    with open(IMG_PATH + example.filename.decode(), 'rb') as img:
        encoded_image_data = img.read()
    image_format = example.img_format

    xmins = example.xmins
    xmaxs = example.xmaxs
    ymins = example.ymins
    ymaxs = example.ymaxs

    classes_text = example.classes_text
    classes = example.classes

    tf_example = tf.train.Example(features=tf.train.Features(feature={
        'image/height': dataset_util.int64_feature(height),
        'image/width': dataset_util.int64_feature(width),
        'image/filename': dataset_util.bytes_feature(filename),
        'image/source_id': dataset_util.bytes_feature(filename),
        'image/encoded': dataset_util.bytes_feature(encoded_image_data),
        'image/format': dataset_util.bytes_feature(image_format),
        'image/object/bbox/xmin': dataset_util.float_list_feature(xmins),
        'image/object/bbox/xmax': dataset_util.float_list_feature(xmaxs),
        'image/object/bbox/ymin': dataset_util.float_list_feature(ymins),
        'image/object/bbox/ymax': dataset_util.float_list_feature(ymaxs),
        'image/object/class/text': dataset_util.bytes_list_feature(classes_text),
        'image/object/class/label': dataset_util.int64_list_feature(classes),
    }))
    return tf_example


def main(_):
    writer = tf.python_io.TFRecordWriter(TFRECORD_PATH)

    description_df = pd.read_csv(CSV_PATH)
    img_files = description_df.filename.unique()

    bar = Bar('Processing', max=len(img_files))
    for img_file in img_files:
        file_row = description_df[description_df.filename == img_file].iloc[0]
        example = Example(
            bytes(file_row.filename, 'utf-8'), bytes(file_row.img_format, 'utf-8'), file_row.height, file_row.width)
        for _, row in description_df[description_df.filename == img_file].iterrows():
            example.xmins.append(row['x_min'] / row['width'])
            example.ymins.append(row['y_min'] / row['height'])
            example.xmaxs.append(row['x_max'] / row['width'])
            example.ymaxs.append(row['y_max'] / row['height'])
            example.classes_text.append(bytes(row['class'], 'utf-8'))
            example.classes.append(classes_id[row['class']])
        tf_example = create_tf_example(example)
        writer.write(tf_example.SerializeToString())
        bar.next()

    writer.close()
    bar.finish()


if __name__ == '__main__':
    tf.app.run()
