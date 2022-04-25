using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Img_Proc {
    //{
    //    public partial class Form1 : Form
    //    {
    //        public Form1()
    //        {
    //            InitializeComponent();
    //        }

    //        private void button3_Click(object sender, EventArgs e)
    //        {

    //        }

    //        private void button4_Click(object sender, EventArgs e)
    //        {

    //        }
    //    }
    namespace Namespace
    {

        using np = numpy;

        using glob;

        using plt = matplotlib.pyplot;

        using skimage.io;

        using skimage.color;

        using skimage.filters;

        using np = numpy;

        using imutils;

        using cv2;

        using plt = matplotlib.pyplot;

        using mpimg = matplotlib.image;

        using os;

        using decode = pyzbar.pyzbar.decode;

        using pyzbar = pyzbar.pyzbar;

        using cv2;

        using glob;

        using tqdm = tqdm.tqdm;

        using EAN13 = barcode.EAN13;

        using ImageWriter = barcode.writer.ImageWriter;

        public static class Module
        {

            public static object video_path = "./vidlight_ipad_01.MOV";

            public static object address_path = "./frames_ipad_light/";

            public static object cap = cv2.VideoCapture(video_path);

            public static object i = 0;

            static Module()
            {
                cv2.imwrite(address_path + "Fipad_" + i.ToString() + ".jpg", frame);
                cap.release();
                cv2.destroyAllWindows();
            }

            public static object i = 1;
        }
    }
}
