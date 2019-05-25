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

namespace Chatime.ViewModels.Embed
{
    public partial class Teas : UserControl
    {
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
            TeaButtonDesign();
        }
       
        public void TeaButtonDesign()
        {
            var BaseColour = Color.FromArgb(79, 26, 108);
            var TransparentColor = Color.FromArgb(0, 255, 255, 255);

            this.Tea1.BackColor = BaseColour;
            this.Tea1.FlatAppearance.BorderSize = 0;
            this.Tea1.FlatAppearance.BorderColor = TransparentColor;

            this.Tea2.BackColor = BaseColour;
            this.Tea2.FlatAppearance.BorderSize = 0;
            this.Tea2.FlatAppearance.BorderColor = TransparentColor;

            this.Tea3.BackColor = BaseColour;
            this.Tea3.FlatAppearance.BorderSize = 0;
            this.Tea3.FlatAppearance.BorderColor = TransparentColor;

            this.Tea4.BackColor = BaseColour;
            this.Tea4.FlatAppearance.BorderSize = 0;
            this.Tea4.FlatAppearance.BorderColor = TransparentColor;

            this.Tea5.BackColor = BaseColour;
            this.Tea5.FlatAppearance.BorderSize = 0;
            this.Tea5.FlatAppearance.BorderColor = TransparentColor;

            this.Tea6.BackColor = BaseColour;
            this.Tea6.FlatAppearance.BorderSize = 0;
            this.Tea6.FlatAppearance.BorderColor = TransparentColor;

            this.Tea7.BackColor = BaseColour;
            this.Tea7.FlatAppearance.BorderSize = 0;
            this.Tea7.FlatAppearance.BorderColor = TransparentColor;

            this.Tea8.BackColor = BaseColour;
            this.Tea8.FlatAppearance.BorderSize = 0;
            this.Tea8.FlatAppearance.BorderColor = TransparentColor;

            this.Tea9.BackColor = BaseColour;
            this.Tea9.FlatAppearance.BorderSize = 0;
            this.Tea9.FlatAppearance.BorderColor = TransparentColor;

            this.Tea10.BackColor = BaseColour;
            this.Tea10.FlatAppearance.BorderSize = 0;
            this.Tea10.FlatAppearance.BorderColor = TransparentColor;

        }
    }
}
