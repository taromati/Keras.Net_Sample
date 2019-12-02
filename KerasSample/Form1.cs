using Keras.Models;
using Keras.PreProcessing.Image;
using Numpy;
using Numpy.Models;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerasSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //# Load the model
            //model = tensorflow.keras.models.load_model('keras_model.h5')
            var model = Model.LoadModel("keras_model.h5");

            //# Create the array of the right shape to feed into the keras model
            //# The 'length' or number of images you can put into the array is
            //# determined by the first position in the shape tuple, in this case 1.
            //data = np.ndarray(shape = (1, 224, 224, 3), dtype = np.float32);
            Shape s = new Shape(1, 224, 224, 3);
            NDarray data = np.empty(s, np.float32);

            //# Replace this with the path to your image
            //image = Image.open('Path to your image')
            var image = ImageUtil.LoadImg("240px-Strawberry_BNC.jpg", target_size: (224, 224));

            //# Make sure to resize all images to 224, 224 otherwise they won't fit in the array
            //image = image.resize((224, 224))
            //image_array = np.asarray(image)
            NDarray image_array = ImageUtil.ImageToArray(image);

            //# Normalize the image
            //normalized_image_array = (image_array.astype(np.float32) / 127.0) - 1
            var normalized_image_array = (image_array.astype(np.float32) / 127.0) - 1;

            //# Load the image into the array
            //data[0] = normalized_image_array
            data[0] = normalized_image_array;

            //# run the inference
            //prediction = model.predict(data)
            //print(prediction)
            var prediction = model.Predict(data);
            Console.WriteLine(prediction);
        }
    }
}
