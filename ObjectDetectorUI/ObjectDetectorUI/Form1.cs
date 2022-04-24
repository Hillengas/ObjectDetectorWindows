using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDetectorUI
{
    public partial class FormPictureRecognizer : Form
    {
        private string _imagePath = "";

        public FormPictureRecognizer()
        {
            InitializeComponent();            
        }

        private void BtnPictureChooser_Click(object sender, EventArgs e)
        {
            // open file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                _imagePath = openFileDialog.FileName;
            }
        }

        private static string RunPythonFileML(string path)
        {
            var start = new ProcessStartInfo
            {
                FileName = @"C:\Users\Alex\AppData\Local\Programs\Python\Python36\python.exe",
                Arguments = @"C:\Users\Alex\Documents\GitHub\ObjectDetectorWindows\ObjectDetectorUI\ObjectDetectorLogic\load_tf_model.py",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            // add _imagePath to the arguments
            start.Arguments += " " + path;

            var result = "";
            
            using (var process = Process.Start(start))
            {
                using (var reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                    Console.Write(result);
                }

                using (var reader = process.StandardError)
                {
                    var resultError = reader.ReadToEnd();
                    Console.Write(resultError);
                }
            }

            return result;
        }

        private void BtnDoML_Click(object sender, EventArgs e)
        {
            var result = "";
            if (_imagePath != "") result = RunPythonFileML(_imagePath);
            result = result.Replace("\r\n", string.Empty);
            
            // cast result to PictureClasses
            var pictureClasses = (PictureClasses)Enum.Parse(typeof(PictureClasses), result);
            
            // display result
            TxtBoxResultML.Text = pictureClasses.ToString();

        }

        // create enum for picture classes of fashion
        public enum PictureClasses
        {
            [Description("T-shirt")]
            Tshirt,
            [Description("Trouser")]
            Trouser,
            [Description("Pullover")]
            Pullover,
            [Description("Dress")]
            Dress,
            [Description("Coat")]
            Coat,
            [Description("Sandal")]
            Sandal,
            [Description("Shirt")]
            Shirt,
            [Description("Sneaker")]
            Sneaker,
            [Description("Bag")]
            Bag,
            [Description("Ankle boot")]
            AnkleBoot
        }
    }
}
