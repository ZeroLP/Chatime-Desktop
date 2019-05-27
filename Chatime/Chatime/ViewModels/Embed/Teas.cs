using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Chatime.ViewModels.Embed
{
    public partial class Teas : UserControl
    {
        public static Assembly assembly = Assembly.GetExecutingAssembly();
        public static string resourceName = "Chatime.Teas.json";

        public static Stream stream = assembly.GetManifestResourceStream(resourceName);
        public static StreamReader reader = new StreamReader(stream);
        public static string result = reader.ReadToEnd();
        Modules.TeaModule.TeaClass TModule = JsonConvert.DeserializeObject<Modules.TeaModule.TeaClass>(result);

        public Teas()
        {
            InitializeComponent();
            InitialiseDesign();
        }

        public void InitialiseDesign()
        {
            var BaseColour = Color.FromArgb(79, 26, 108);
            var TransparentColor = Color.FromArgb(0, 255, 255, 255);
            this.BackColor = Color.White;

            NameLabel.ForeColor = Color.White;
            NameLabel.BackColor = BaseColour;
            TeaBox.BackColor = BaseColour;

            TeaBox.Load(TModule.Tea1.Image);
            TeaLabel.Text = TModule.Tea1.Information;
            NameLabel.Text = TModule.Tea1.Name;

            TeaButtonDesign();
        }
       
        public void TeaButtonDesign()
        {
            var BaseColour = Color.FromArgb(79, 26, 108);
            var TransparentColor = Color.FromArgb(0, 255, 255, 255);

            this.Tea1.Text = TModule.Tea1.Name;
            this.Tea1.BackColor = BaseColour;
            this.Tea1.FlatAppearance.BorderSize = 0;
            this.Tea1.FlatAppearance.BorderColor = TransparentColor;

            this.Tea2.Text = TModule.Tea2.Name;
            this.Tea2.BackColor = BaseColour;
            this.Tea2.FlatAppearance.BorderSize = 0;
            this.Tea2.FlatAppearance.BorderColor = TransparentColor;

            this.Tea3.Text = TModule.Tea3.Name;
            this.Tea3.BackColor = BaseColour;
            this.Tea3.FlatAppearance.BorderSize = 0;
            this.Tea3.FlatAppearance.BorderColor = TransparentColor;

            this.Tea4.Text = TModule.Tea4.Name;
            this.Tea4.BackColor = BaseColour;
            this.Tea4.FlatAppearance.BorderSize = 0;
            this.Tea4.FlatAppearance.BorderColor = TransparentColor;

            this.Tea5.Text = TModule.Tea5.Name;
            this.Tea5.BackColor = BaseColour;
            this.Tea5.FlatAppearance.BorderSize = 0;
            this.Tea5.FlatAppearance.BorderColor = TransparentColor;

            this.Tea6.Text = TModule.Tea6.Name;
            this.Tea6.BackColor = BaseColour;
            this.Tea6.FlatAppearance.BorderSize = 0;
            this.Tea6.FlatAppearance.BorderColor = TransparentColor;

            this.Tea7.Text = TModule.Tea7.Name;
            this.Tea7.BackColor = BaseColour;
            this.Tea7.FlatAppearance.BorderSize = 0;
            this.Tea7.FlatAppearance.BorderColor = TransparentColor;

            this.Tea8.Text = TModule.Tea8.Name;
            this.Tea8.BackColor = BaseColour;
            this.Tea8.FlatAppearance.BorderSize = 0;
            this.Tea8.FlatAppearance.BorderColor = TransparentColor;

            this.Tea9.Text = TModule.Tea9.Name;
            this.Tea9.BackColor = BaseColour;
            this.Tea9.FlatAppearance.BorderSize = 0;
            this.Tea9.FlatAppearance.BorderColor = TransparentColor;

            this.Tea10.Text = TModule.Tea10.Name;
            this.Tea10.BackColor = BaseColour;
            this.Tea10.FlatAppearance.BorderSize = 0;
            this.Tea10.FlatAppearance.BorderColor = TransparentColor;

            this.Tea11.Text = TModule.Tea11.Name;
            this.Tea11.BackColor = BaseColour;
            this.Tea11.FlatAppearance.BorderSize = 0;
            this.Tea11.FlatAppearance.BorderColor = TransparentColor;

            this.Tea12.Text = TModule.Tea12.Name;
            this.Tea12.BackColor = BaseColour;
            this.Tea12.FlatAppearance.BorderSize = 0;
            this.Tea12.FlatAppearance.BorderColor = TransparentColor;

            this.Tea13.Text = TModule.Tea13.Name;
            this.Tea13.BackColor = BaseColour;
            this.Tea13.FlatAppearance.BorderSize = 0;
            this.Tea13.FlatAppearance.BorderColor = TransparentColor;

            this.Tea14.Text = TModule.Tea14.Name;
            this.Tea14.BackColor = BaseColour;
            this.Tea14.FlatAppearance.BorderSize = 0;
            this.Tea14.FlatAppearance.BorderColor = TransparentColor;

            this.Tea15.Text = TModule.Tea15.Name;
            this.Tea15.BackColor = BaseColour;
            this.Tea15.FlatAppearance.BorderSize = 0;
            this.Tea15.FlatAppearance.BorderColor = TransparentColor;

            this.Tea16.Text = TModule.Tea16.Name;
            this.Tea16.BackColor = BaseColour;
            this.Tea16.FlatAppearance.BorderSize = 0;
            this.Tea16.FlatAppearance.BorderColor = TransparentColor;

            this.Tea17.Text = TModule.Tea17.Name;
            this.Tea17.BackColor = BaseColour;
            this.Tea17.FlatAppearance.BorderSize = 0;
            this.Tea17.FlatAppearance.BorderColor = TransparentColor;

        }

        private void Tea1_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea1.Image);
            TeaLabel.Text = TModule.Tea1.Information;
            NameLabel.Text = TModule.Tea1.Name;
        }

        private void Tea2_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea2.Image);
            TeaLabel.Text = TModule.Tea2.Information;
            NameLabel.Text = TModule.Tea2.Name;
        }

        private void Tea3_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea3.Image);
            TeaLabel.Text = TModule.Tea3.Information;
            NameLabel.Text = TModule.Tea3.Name;
        }

        private void Tea4_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea4.Image);
            TeaLabel.Text = TModule.Tea4.Information;
            NameLabel.Text = TModule.Tea4.Name;
        }

        private void Tea5_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea5.Image);
            TeaLabel.Text = TModule.Tea5.Information;
            NameLabel.Text = TModule.Tea5.Name;
        }

        private void Tea6_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea6.Image);
            TeaLabel.Text = TModule.Tea6.Information;
            NameLabel.Text = TModule.Tea6.Name;
        }

        private void Tea7_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea7.Image);
            TeaLabel.Text = TModule.Tea7.Information;
            NameLabel.Text = TModule.Tea7.Name;
        }

        private void Tea8_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea8.Image);
            TeaLabel.Text = TModule.Tea8.Information;
            NameLabel.Text = TModule.Tea8.Name;
        }

        private void Tea9_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea9.Image);
            TeaLabel.Text = TModule.Tea9.Information;
            NameLabel.Text = TModule.Tea9.Name;
        }

        private void Tea10_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea10.Image);
            TeaLabel.Text = TModule.Tea10.Information;
            NameLabel.Text = TModule.Tea10.Name;
        }

        private void Tea11_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea11.Image);
            TeaLabel.Text = TModule.Tea11.Information;
            NameLabel.Text = TModule.Tea11.Name;
        }

        private void Tea12_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea12.Image);
            TeaLabel.Text = TModule.Tea12.Information;
            NameLabel.Text = TModule.Tea12.Name;
        }

        private void Tea13_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea13.Image);
            TeaLabel.Text = TModule.Tea13.Information;
            NameLabel.Text = TModule.Tea13.Name;
        }

        private void Tea14_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea14.Image);
            TeaLabel.Text = TModule.Tea14.Information;
            NameLabel.Text = TModule.Tea14.Name;
        }

        private void Tea15_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea15.Image);
            TeaLabel.Text = TModule.Tea15.Information;
            NameLabel.Text = TModule.Tea15.Name;
        }

        private void Tea16_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea16.Image);
            TeaLabel.Text = TModule.Tea16.Information;
            NameLabel.Text = TModule.Tea16.Name;
        }

        private void Tea17_Click(object sender, EventArgs e)
        {
            TeaBox.Load(TModule.Tea17.Image);
            TeaLabel.Text = TModule.Tea17.Information;
            NameLabel.Text = TModule.Tea17.Name;
        }
    }
}
