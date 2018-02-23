using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TerraViewer
{
    [DefaultEvent("Click")]

    public partial class WwtButton : UserControl, IButtonControl
    {
		//Bitmap btnStartRest = global::TerraViewer.Properties.Resources.BtnStartRest;
		Bitmap btnStartRest = global::TerraViewer.Properties.Resources.btnstartrest_mod;

		Bitmap btnStartHover = global::TerraViewer.Properties.Resources.BtnStartHover;

		//Bitmap btnStartPressed = global::TerraViewer.Properties.Resources.BtnStartPushed;
		Bitmap btnStartPressed = global::TerraViewer.Properties.Resources.btnstartpushed_mod;

		Bitmap btnStartDisabled = global::TerraViewer.Properties.Resources.BtnStartDisabled;
        Bitmap btnStartSelected = global::TerraViewer.Properties.Resources.BtnStartSelected;

		//Bitmap btnEndRest = global::TerraViewer.Properties.Resources.BtnEndRest;
		Bitmap btnEndRest = global::TerraViewer.Properties.Resources.btnendrest_mod;

		Bitmap btnEndHover = global::TerraViewer.Properties.Resources.BtnEndHover;

		//Bitmap btnEndPressed = global::TerraViewer.Properties.Resources.BtnEndPushed;
		Bitmap btnEndPressed = global::TerraViewer.Properties.Resources.btnendpushed_mod;

		Bitmap btnEndDisabled = global::TerraViewer.Properties.Resources.BtnEndDisabled;
        Bitmap btnEndSelected = global::TerraViewer.Properties.Resources.BtnEndSelected;

        public WwtButton()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]

        public override string Text
        {
            get
            {
                return base.Text;
                
            }
            set
            {
                this.Invalidate();
                base.Text = value;
            }
        }
        Bitmap imageEnabled;

        public Bitmap ImageEnabled
        {
            get { return imageEnabled; }
            set 
            {
                imageEnabled = value;
                Refresh();
            }
        }
        Bitmap imageDisabled;

        public Bitmap ImageDisabled
        {
            get { return imageDisabled; }
            set
            {
                imageDisabled = value;
                Refresh();
            }
        }

        private DialogResult dialogResult = 0;
                    
        public DialogResult DialogResult
        {
            get 
            {
                return dialogResult;
            }
            set
            {
                dialogResult = value; 
            }
        }


        bool selected = false;

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        bool pressed = false;
        bool hover = false;


        private void WwtButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RectangleF rectf = new RectangleF(0, 0, Width, Height);
            Bitmap start = btnStartRest;
            Bitmap end = btnEndRest;
          
            if (hover)
            {
                start = btnStartHover;
                end = btnEndHover;

            }

            if (pressed)
            {
                start = btnStartPressed;
                end = btnEndPressed;

            }



            if (Enabled)
            {
                g.DrawImage(start, new Rectangle(0, 0, Width / 2, 33), new Rectangle(0, 0, Width / 2, 33), GraphicsUnit.Pixel);
                g.DrawImage(end, new Rectangle(Width / 2, 0, Width / 2, 33), new Rectangle(btnEndRest.Width - Width / 2, 0, Width / 2, 33), GraphicsUnit.Pixel);
                if (imageEnabled != null)
                {
                    g.DrawImage(imageEnabled, new Rectangle((Width / 2)-(imageEnabled.Width/2), (Height/2)-(imageEnabled.Height/2), imageEnabled.Width,imageEnabled.Height), new Rectangle(0,0,imageEnabled.Width,ImageEnabled.Height), GraphicsUnit.Pixel);
                }
                g.DrawString(this.Text, UiTools.StandardRegular, UiTools.StadardTextBrush, rectf,UiTools.StringFormatCenterCenter);
            }
            else
            {
                g.DrawImage(btnStartDisabled, new Rectangle(0, 0, Width/2, 33), new Rectangle(0, 0, Width/2, 33), GraphicsUnit.Pixel);
                g.DrawImage(btnEndDisabled, new Rectangle(Width / 2, 0, Width / 2, 33), new Rectangle(btnEndRest.Width - Width / 2, 0, Width / 2, 33), GraphicsUnit.Pixel);
                if (imageDisabled != null)
                {
                    g.DrawImage(imageDisabled, new Rectangle((Width / 2) - (imageDisabled.Width / 2), (Height / 2) - (imageDisabled.Height / 2), imageDisabled.Width, imageDisabled.Height), new Rectangle(0, 0, imageDisabled.Width, imageDisabled.Height), GraphicsUnit.Pixel);
                }
                else if (imageEnabled != null)
                {
                    g.DrawImage(imageEnabled, new Rectangle((Width / 2)-(imageEnabled.Width/2), (Height/2)-(imageEnabled.Height/2), imageEnabled.Width,imageEnabled.Height), new Rectangle(0,0,imageEnabled.Width,ImageEnabled.Height), GraphicsUnit.Pixel);
                }
                g.DrawString(this.Text, UiTools.StandardRegular, UiTools.DisabledTextBrush, rectf,UiTools.StringFormatCenterCenter);
            }


        }

        private void WwtButton_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            Refresh();
        }

        private void WwtButton_MouseEnter(object sender, EventArgs e)
        {
            hover = true;
            Refresh();
        }

        private void WwtButton_MouseLeave(object sender, EventArgs e)
        {
            pressed = false;
            hover = false;
            Refresh();
        }

        private void WwtButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void WwtButton_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            Refresh();
        }

        #region IButtonControl Members


        public void NotifyDefault(bool value)
        {
            
        }

        public void PerformClick()
        {
            OnClick(new EventArgs());
        }

        #endregion
    }
}
