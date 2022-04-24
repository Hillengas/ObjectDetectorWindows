
# TensorFlow and tf.keras
import tensorflow as tf

# Helper libraries
import numpy as np
import matplotlib.pyplot as plt

# enable np functionality in tf
from tensorflow.python.ops.numpy_ops import np_config
np_config.enable_numpy_behavior()


print(tf.__version__)

# load mnist fashion dataset from keras
mnist = tf.keras.datasets.fashion_mnist

# load train and test data
(training_images, training_labels), (test_images, test_labels) = mnist.load_data()

# scale the pixel values to a range of 0 to 1
training_images = training_images / 255.0
test_images = test_images / 255.0

# print the shape of the training images
print(training_images.shape)

# define model 
model = tf.keras.models.Sequential([
    tf.keras.layers.Flatten(input_shape=(28, 28)),
    tf.keras.layers.Dense(128, activation='relu'),
    tf.keras.layers.Dense(10, activation='softmax')
])

# compile the model
model.compile(optimizer='adam',
                loss='sparse_categorical_crossentropy',
                metrics=['accuracy'])

# train the model
model.fit(training_images, training_labels, epochs=10)

# evaluate the model
test_loss, test_acc = model.evaluate(test_images, test_labels)

# print the accuracy
print('\nTest accuracy:', test_acc)


# make predictions / attach softmax function
probability_model = tf.keras.Sequential([model, 
                                         tf.keras.layers.Softmax()])

predictions = probability_model.predict(test_images)
predictions[0]


class_names = ['T-shirt/top', 'Trouser', 'Pullover', 'Dress', 'Coat',
               'Sandal', 'Shirt', 'Sneaker', 'Bag', 'Ankle boot']


# test my own image

# load image
img = plt.imread('/content/pullover_black.jpg')

# convert img from float to integer
img = img.astype(np.uint8)

# resize img to 28x28
img = tf.image.resize(img, (28, 28))
print(img.shape)

# set img to single channel
img = img[:, :, 0]

# convert img from float to integer, because tf output is in float, we need integer
#img = img.astype(np.uint8)

# from 255 (int) to 0/1 (float)
img = img / 255.0

# invert image
img = 1 - img

print(img.shape)

plt.figure()
plt.imshow(img)
plt.colorbar()
plt.grid(False)
plt.show()


# Add the image to a batch where it's the only member.
img = (np.expand_dims(img,0))


predictions_single = probability_model.predict(img)

print(predictions_single)


np.argmax(predictions_single)


# save model to desktop
model.save('/content/model.h5')