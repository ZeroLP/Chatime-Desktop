using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatime.ViewModels.Embed
{
    public partial class Home : UserControl
    {
        
        public Home()
        {
            InitializeComponent();
            LoadNextImage();
        }
         
        private int ImageNumber = 1;

        private void LoadNextImage()
        {
            if(ImageNumber == 1)
            {
                SliderBox.Load("https://chatime.com.au/wp-content/uploads/sites/6/2019/05/190319_Chatime_Hot_Fruity_Generic_1920x650_Desktop.jpg");
            }

            if(ImageNumber == 2)
            {
                SliderBox.Load("https://chatime.com.au/wp-content/uploads/sites/6/2019/03/190301_Chatime_MyFirstTime_Desktop_Homepage_Balls.jpg");
            }

            if(ImageNumber == 3)
            {
                SliderBox.Load("https://chatime.com.au/wp-content/uploads/sites/6/2019/03/homepage-referafriend.jpeg");
                ImageNumber = 1;
            }
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
