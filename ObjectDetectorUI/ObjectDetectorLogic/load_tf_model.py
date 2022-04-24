# TensorFlow and tf.keras
import tensorflow as tf

# Helper libraries
import numpy as np
import matplotlib.pyplot as plt

# enable np functionality in tf
from tensorflow.python.ops.numpy_ops import np_config
np_config.enable_numpy_behavior()

import sys


# main function with arguments
def main(argv):
    analyse_picture(argv[1])
    #print(argv)


def analyse_picture(picturePath):
    # load model
    model = tf.keras.models.load_model('C:/Users/Alex/Documents/GitHub/ObjectDetectorWindows/ObjectDetectorUI/ObjectDetectorLogic/model.h5')
    # make predictions / attach softmax function
    probability_model = tf.keras.Sequential([model, 
                                         tf.keras.layers.Softmax()])


    # test my own image -------------
    # load image
    #img = plt.imread('C:/Users/Alex/Desktop/Bilder_DeepLearning/pullover_black.jpg')
    img = plt.imread(picturePath)

    # convert img from float to integer
    img = img.astype(np.uint8)

    # resize img to 28x28
    img = tf.image.resize(img, (28, 28))
    #print(img.shape)

    # set img to single channel
    img = img[:, :, 0]

    # convert img from float to integer, because tf output is in float, we need integer
    #img = img.astype(np.uint8)

    # from 255 (int) to 0/1 (float)
    img = img / 255.0

    # invert image
    img = 1 - img

    #print(img.shape)

    #plt.figure()
    #plt.imshow(img)
    #plt.colorbar()
    #plt.grid(False)
    #plt.show()


    # Add the image to a batch where it's the only member.
    img = (np.expand_dims(img,0))


    predictions_single = probability_model.predict(img)

    #print(predictions_single)
    print(np.argmax(predictions_single))




if __name__ == "__main__":
    main(sys.argv)