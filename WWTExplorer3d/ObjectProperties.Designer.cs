namespace TerraViewer
{
    partial class ObjectProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.thumbnail = new System.Windows.Forms.PictureBox();
			this.decText = new System.Windows.Forms.Label();
			this.raText = new System.Windows.Forms.Label();
			this.altText = new System.Windows.Forms.Label();
			this.azText = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.magnitudeLabel = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.distanceLabel = new System.Windows.Forms.Label();
			this.magnitudeValue = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.classificationText = new System.Windows.Forms.Label();
			this.distanceValue = new System.Windows.Forms.Label();
			this.azLabel = new System.Windows.Forms.Label();
			this.altLabel = new System.Windows.Forms.Label();
			this.decLabel = new System.Windows.Forms.Label();
			this.raLabel = new System.Windows.Forms.Label();
			this.constellationName = new System.Windows.Forms.Label();
			this.closeBox = new System.Windows.Forms.PictureBox();
			this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
			this.nameValues = new System.Windows.Forms.Label();
			this.creditsText = new System.Windows.Forms.Label();
			this.riseLabel = new System.Windows.Forms.Label();
			this.imageCreditsText = new System.Windows.Forms.Label();
			this.creditsLink = new System.Windows.Forms.LinkLabel();
			this.TileBarText = new System.Windows.Forms.Label();
			this.transitLabel = new System.Windows.Forms.Label();
			this.setLabel = new System.Windows.Forms.Label();
			this.riseText = new System.Windows.Forms.Label();
			this.transitText = new System.Windows.Forms.Label();
			this.setText = new System.Windows.Forms.Label();
			this.ShowObject = new TerraViewer.WwtButton();
			this.CloseButton = new TerraViewer.WwtButton();
			this.research = new TerraViewer.WwtButton();
			((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
			this.SuspendLayout();
			// 
			// thumbnail
			// 
			this.thumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.thumbnail.Location = new System.Drawing.Point(15, 125);
			this.thumbnail.Name = "thumbnail";
			this.thumbnail.Size = new System.Drawing.Size(98, 47);
			this.thumbnail.TabIndex = 0;
			this.thumbnail.TabStop = false;
			this.thumbnail.Click += new System.EventHandler(this.thumbnail_Click);
			// 
			// decText
			// 
			this.decText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.decText.BackColor = System.Drawing.Color.Transparent;
			this.decText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decText.ForeColor = System.Drawing.Color.Transparent;
			this.decText.Location = new System.Drawing.Point(47, 240);
			this.decText.Name = "decText";
			this.decText.Size = new System.Drawing.Size(78, 15);
			this.decText.TabIndex = 2;
			this.decText.Text = "00 : 00 : 00";
			this.decText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.decText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.decText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.decText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// raText
			// 
			this.raText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.raText.BackColor = System.Drawing.Color.Transparent;
			this.raText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.raText.ForeColor = System.Drawing.Color.Transparent;
			this.raText.Location = new System.Drawing.Point(47, 222);
			this.raText.Name = "raText";
			this.raText.Size = new System.Drawing.Size(78, 15);
			this.raText.TabIndex = 1;
			this.raText.Text = "00h00m00s";
			this.raText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.raText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.raText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.raText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// altText
			// 
			this.altText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.altText.BackColor = System.Drawing.Color.Transparent;
			this.altText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.altText.ForeColor = System.Drawing.Color.Transparent;
			this.altText.Location = new System.Drawing.Point(47, 258);
			this.altText.Name = "altText";
			this.altText.Size = new System.Drawing.Size(78, 15);
			this.altText.TabIndex = 1;
			this.altText.Text = "00 : 00 : 00";
			this.altText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.altText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.altText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.altText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// azText
			// 
			this.azText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.azText.BackColor = System.Drawing.Color.Transparent;
			this.azText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.azText.ForeColor = System.Drawing.Color.Transparent;
			this.azText.Location = new System.Drawing.Point(47, 276);
			this.azText.Name = "azText";
			this.azText.Size = new System.Drawing.Size(78, 15);
			this.azText.TabIndex = 2;
			this.azText.Text = "00 : 00 : 00";
			this.azText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.azText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.azText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.azText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(11, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 18);
			this.label4.TabIndex = 2;
			this.label4.Text = "Names:";
			this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// magnitudeLabel
			// 
			this.magnitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.magnitudeLabel.AutoSize = true;
			this.magnitudeLabel.BackColor = System.Drawing.Color.Transparent;
			this.magnitudeLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magnitudeLabel.ForeColor = System.Drawing.Color.Transparent;
			this.magnitudeLabel.Location = new System.Drawing.Point(138, 220);
			this.magnitudeLabel.Name = "magnitudeLabel";
			this.magnitudeLabel.Size = new System.Drawing.Size(76, 18);
			this.magnitudeLabel.TabIndex = 2;
			this.magnitudeLabel.Text = "Magnitude:";
			this.magnitudeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.magnitudeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.magnitudeLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// distanceLabel
			// 
			this.distanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.distanceLabel.AutoSize = true;
			this.distanceLabel.BackColor = System.Drawing.Color.Transparent;
			this.distanceLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceLabel.ForeColor = System.Drawing.Color.Transparent;
			this.distanceLabel.Location = new System.Drawing.Point(138, 238);
			this.distanceLabel.Name = "distanceLabel";
			this.distanceLabel.Size = new System.Drawing.Size(62, 18);
			this.distanceLabel.TabIndex = 2;
			this.distanceLabel.Text = "Distance:";
			this.distanceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.distanceLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.distanceLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// magnitudeValue
			// 
			this.magnitudeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.magnitudeValue.BackColor = System.Drawing.Color.Transparent;
			this.magnitudeValue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.magnitudeValue.ForeColor = System.Drawing.Color.Transparent;
			this.magnitudeValue.Location = new System.Drawing.Point(220, 220);
			this.magnitudeValue.Name = "magnitudeValue";
			this.magnitudeValue.Size = new System.Drawing.Size(60, 17);
			this.magnitudeValue.TabIndex = 2;
			this.magnitudeValue.Text = "8.5";
			this.magnitudeValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.magnitudeValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.magnitudeValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.magnitudeValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(119, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 18);
			this.label7.TabIndex = 2;
			this.label7.Text = "Classification:";
			this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.label7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// classificationText
			// 
			this.classificationText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.classificationText.AutoSize = true;
			this.classificationText.BackColor = System.Drawing.Color.Transparent;
			this.classificationText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.classificationText.ForeColor = System.Drawing.Color.Transparent;
			this.classificationText.Location = new System.Drawing.Point(119, 139);
			this.classificationText.Name = "classificationText";
			this.classificationText.Size = new System.Drawing.Size(48, 18);
			this.classificationText.TabIndex = 2;
			this.classificationText.Text = "Galaxy";
			this.classificationText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.classificationText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.classificationText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// distanceValue
			// 
			this.distanceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.distanceValue.BackColor = System.Drawing.Color.Transparent;
			this.distanceValue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distanceValue.ForeColor = System.Drawing.Color.Transparent;
			this.distanceValue.Location = new System.Drawing.Point(217, 238);
			this.distanceValue.Name = "distanceValue";
			this.distanceValue.Size = new System.Drawing.Size(63, 17);
			this.distanceValue.TabIndex = 2;
			this.distanceValue.Text = "n/a";
			this.distanceValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.distanceValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.distanceValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.distanceValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// azLabel
			// 
			this.azLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.azLabel.AutoSize = true;
			this.azLabel.BackColor = System.Drawing.Color.Transparent;
			this.azLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.azLabel.ForeColor = System.Drawing.Color.Transparent;
			this.azLabel.Location = new System.Drawing.Point(12, 276);
			this.azLabel.Name = "azLabel";
			this.azLabel.Size = new System.Drawing.Size(28, 18);
			this.azLabel.TabIndex = 5;
			this.azLabel.Text = "Az :";
			this.azLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.azLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.azLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// altLabel
			// 
			this.altLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.altLabel.AutoSize = true;
			this.altLabel.BackColor = System.Drawing.Color.Transparent;
			this.altLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.altLabel.ForeColor = System.Drawing.Color.Transparent;
			this.altLabel.Location = new System.Drawing.Point(12, 258);
			this.altLabel.Name = "altLabel";
			this.altLabel.Size = new System.Drawing.Size(33, 18);
			this.altLabel.TabIndex = 4;
			this.altLabel.Text = "Alt : ";
			this.altLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.altLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.altLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// decLabel
			// 
			this.decLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.decLabel.AutoSize = true;
			this.decLabel.BackColor = System.Drawing.Color.Transparent;
			this.decLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decLabel.ForeColor = System.Drawing.Color.Transparent;
			this.decLabel.Location = new System.Drawing.Point(11, 240);
			this.decLabel.Name = "decLabel";
			this.decLabel.Size = new System.Drawing.Size(39, 18);
			this.decLabel.TabIndex = 6;
			this.decLabel.Text = "Dec : ";
			this.decLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.decLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.decLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// raLabel
			// 
			this.raLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.raLabel.AutoSize = true;
			this.raLabel.BackColor = System.Drawing.Color.Transparent;
			this.raLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.raLabel.ForeColor = System.Drawing.Color.Transparent;
			this.raLabel.Location = new System.Drawing.Point(12, 222);
			this.raLabel.Name = "raLabel";
			this.raLabel.Size = new System.Drawing.Size(33, 18);
			this.raLabel.TabIndex = 3;
			this.raLabel.Text = "RA : ";
			this.raLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.raLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.raLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// constellationName
			// 
			this.constellationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.constellationName.AutoSize = true;
			this.constellationName.BackColor = System.Drawing.Color.Transparent;
			this.constellationName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.constellationName.ForeColor = System.Drawing.Color.Transparent;
			this.constellationName.Location = new System.Drawing.Point(119, 157);
			this.constellationName.Name = "constellationName";
			this.constellationName.Size = new System.Drawing.Size(87, 18);
			this.constellationName.TabIndex = 2;
			this.constellationName.Text = "in Ursa Major";
			this.constellationName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.constellationName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.constellationName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// closeBox
			// 
			this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.closeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
			this.closeBox.Image = global::TerraViewer.Properties.Resources.CloseRest;
			this.closeBox.Location = new System.Drawing.Point(199, 105);
			this.closeBox.Name = "closeBox";
			this.closeBox.Size = new System.Drawing.Size(16, 16);
			this.closeBox.TabIndex = 8;
			this.closeBox.TabStop = false;
			this.closeBox.Visible = false;
			this.closeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeBox_MouseDown);
			this.closeBox.MouseEnter += new System.EventHandler(this.closeBox_MouseEnter);
			this.closeBox.MouseLeave += new System.EventHandler(this.closeBox_MouseLeave);
			this.closeBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeBox_MouseUp);
			// 
			// fadeInTimer
			// 
			this.fadeInTimer.Enabled = true;
			this.fadeInTimer.Interval = 10;
			this.fadeInTimer.Tick += new System.EventHandler(this.fadeInTimer_Tick);
			// 
			// nameValues
			// 
			this.nameValues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nameValues.BackColor = System.Drawing.Color.Transparent;
			this.nameValues.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameValues.ForeColor = System.Drawing.Color.Transparent;
			this.nameValues.Location = new System.Drawing.Point(69, 175);
			this.nameValues.Margin = new System.Windows.Forms.Padding(0);
			this.nameValues.Name = "nameValues";
			this.nameValues.Size = new System.Drawing.Size(214, 42);
			this.nameValues.TabIndex = 2;
			this.nameValues.Text = "Names:";
			this.nameValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.nameValues.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.nameValues.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// creditsText
			// 
			this.creditsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.creditsText.AutoEllipsis = true;
			this.creditsText.BackColor = System.Drawing.Color.Transparent;
			this.creditsText.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creditsText.ForeColor = System.Drawing.Color.Transparent;
			this.creditsText.Location = new System.Drawing.Point(12, 340);
			this.creditsText.Name = "creditsText";
			this.creditsText.Size = new System.Drawing.Size(271, 34);
			this.creditsText.TabIndex = 5;
			// 
			// riseLabel
			// 
			this.riseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.riseLabel.AutoSize = true;
			this.riseLabel.BackColor = System.Drawing.Color.Transparent;
			this.riseLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.riseLabel.ForeColor = System.Drawing.Color.Transparent;
			this.riseLabel.Location = new System.Drawing.Point(138, 256);
			this.riseLabel.Name = "riseLabel";
			this.riseLabel.Size = new System.Drawing.Size(35, 18);
			this.riseLabel.TabIndex = 2;
			this.riseLabel.Text = "Rise:";
			this.riseLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.riseLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.riseLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// imageCreditsText
			// 
			this.imageCreditsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.imageCreditsText.AutoSize = true;
			this.imageCreditsText.BackColor = System.Drawing.Color.Transparent;
			this.imageCreditsText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imageCreditsText.ForeColor = System.Drawing.Color.Transparent;
			this.imageCreditsText.Location = new System.Drawing.Point(12, 323);
			this.imageCreditsText.Name = "imageCreditsText";
			this.imageCreditsText.Size = new System.Drawing.Size(93, 18);
			this.imageCreditsText.TabIndex = 2;
			this.imageCreditsText.Text = "Image Credits:";
			// 
			// creditsLink
			// 
			this.creditsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.creditsLink.AutoEllipsis = true;
			this.creditsLink.BackColor = System.Drawing.Color.Transparent;
			this.creditsLink.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.creditsLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
			this.creditsLink.Location = new System.Drawing.Point(12, 362);
			this.creditsLink.Name = "creditsLink";
			this.creditsLink.Size = new System.Drawing.Size(271, 24);
			this.creditsLink.TabIndex = 10;
			this.creditsLink.TabStop = true;
			this.creditsLink.Text = "http:\\\\www.worldwidetelescope.org";
			this.creditsLink.Visible = false;
			this.creditsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLink_LinkClicked);
			// 
			// TileBarText
			// 
			this.TileBarText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.TileBarText.BackColor = System.Drawing.Color.Transparent;
			this.TileBarText.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TileBarText.ForeColor = System.Drawing.Color.Transparent;
			this.TileBarText.Location = new System.Drawing.Point(20, 106);
			this.TileBarText.Name = "TileBarText";
			this.TileBarText.Size = new System.Drawing.Size(85, 15);
			this.TileBarText.TabIndex = 2;
			this.TileBarText.Text = "Finder Scope";
			// 
			// transitLabel
			// 
			this.transitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.transitLabel.AutoSize = true;
			this.transitLabel.BackColor = System.Drawing.Color.Transparent;
			this.transitLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.transitLabel.ForeColor = System.Drawing.Color.Transparent;
			this.transitLabel.Location = new System.Drawing.Point(138, 274);
			this.transitLabel.Name = "transitLabel";
			this.transitLabel.Size = new System.Drawing.Size(52, 18);
			this.transitLabel.TabIndex = 2;
			this.transitLabel.Text = "Transit:";
			this.transitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.transitLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.transitLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// setLabel
			// 
			this.setLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.setLabel.AutoSize = true;
			this.setLabel.BackColor = System.Drawing.Color.Transparent;
			this.setLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setLabel.ForeColor = System.Drawing.Color.Transparent;
			this.setLabel.Location = new System.Drawing.Point(138, 292);
			this.setLabel.Name = "setLabel";
			this.setLabel.Size = new System.Drawing.Size(30, 18);
			this.setLabel.TabIndex = 2;
			this.setLabel.Text = "Set:";
			this.setLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.setLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.setLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// riseText
			// 
			this.riseText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.riseText.BackColor = System.Drawing.Color.Transparent;
			this.riseText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.riseText.ForeColor = System.Drawing.Color.Transparent;
			this.riseText.Location = new System.Drawing.Point(196, 257);
			this.riseText.Name = "riseText";
			this.riseText.Size = new System.Drawing.Size(84, 17);
			this.riseText.TabIndex = 2;
			this.riseText.Text = "n/a";
			this.riseText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.riseText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.riseText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.riseText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// transitText
			// 
			this.transitText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.transitText.BackColor = System.Drawing.Color.Transparent;
			this.transitText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.transitText.ForeColor = System.Drawing.Color.Transparent;
			this.transitText.Location = new System.Drawing.Point(196, 276);
			this.transitText.Name = "transitText";
			this.transitText.Size = new System.Drawing.Size(84, 17);
			this.transitText.TabIndex = 2;
			this.transitText.Text = "n/a";
			this.transitText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.transitText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.transitText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.transitText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// setText
			// 
			this.setText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.setText.BackColor = System.Drawing.Color.Transparent;
			this.setText.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setText.ForeColor = System.Drawing.Color.Transparent;
			this.setText.Location = new System.Drawing.Point(196, 292);
			this.setText.Name = "setText";
			this.setText.Size = new System.Drawing.Size(84, 17);
			this.setText.TabIndex = 2;
			this.setText.Text = "n/a";
			this.setText.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.setText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.setText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.setText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			// 
			// ShowObject
			// 
			this.ShowObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ShowObject.BackColor = System.Drawing.Color.Transparent;
			this.ShowObject.DialogResult = System.Windows.Forms.DialogResult.None;
			this.ShowObject.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowObject.ImageDisabled = null;
			this.ShowObject.ImageEnabled = null;
			this.ShowObject.Location = new System.Drawing.Point(100, 378);
			this.ShowObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ShowObject.MaximumSize = new System.Drawing.Size(140, 33);
			this.ShowObject.Name = "ShowObject";
			this.ShowObject.Selected = false;
			this.ShowObject.Size = new System.Drawing.Size(95, 33);
			this.ShowObject.TabIndex = 11;
			this.ShowObject.Text = "Fly to";
			this.ShowObject.Click += new System.EventHandler(this.ShowObject_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CloseButton.BackColor = System.Drawing.Color.Transparent;
			this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
			this.CloseButton.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButton.ImageDisabled = null;
			this.CloseButton.ImageEnabled = null;
			this.CloseButton.Location = new System.Drawing.Point(202, 378);
			this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CloseButton.MaximumSize = new System.Drawing.Size(140, 33);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Selected = false;
			this.CloseButton.Size = new System.Drawing.Size(84, 33);
			this.CloseButton.TabIndex = 9;
			this.CloseButton.Text = "Close";
			this.CloseButton.Click += new System.EventHandler(this.Close_Click);
			// 
			// research
			// 
			this.research.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.research.BackColor = System.Drawing.Color.Transparent;
			this.research.DialogResult = System.Windows.Forms.DialogResult.None;
			this.research.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.research.ImageDisabled = null;
			this.research.ImageEnabled = null;
			this.research.Location = new System.Drawing.Point(4, 378);
			this.research.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.research.MaximumSize = new System.Drawing.Size(140, 33);
			this.research.Name = "research";
			this.research.Selected = false;
			this.research.Size = new System.Drawing.Size(89, 33);
			this.research.TabIndex = 9;
			this.research.Text = "Research";
			this.research.Visible = false;
			this.research.Click += new System.EventHandler(this.research_Click);
			// 
			// ObjectProperties
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::TerraViewer.Properties.Resources.PropertiesBackground_MOD;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(393, 419);
			this.Controls.Add(this.ShowObject);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.research);
			this.Controls.Add(this.closeBox);
			this.Controls.Add(this.creditsText);
			this.Controls.Add(this.azLabel);
			this.Controls.Add(this.altLabel);
			this.Controls.Add(this.decLabel);
			this.Controls.Add(this.raLabel);
			this.Controls.Add(this.classificationText);
			this.Controls.Add(this.constellationName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TileBarText);
			this.Controls.Add(this.imageCreditsText);
			this.Controls.Add(this.setLabel);
			this.Controls.Add(this.transitLabel);
			this.Controls.Add(this.riseLabel);
			this.Controls.Add(this.distanceLabel);
			this.Controls.Add(this.setText);
			this.Controls.Add(this.transitText);
			this.Controls.Add(this.riseText);
			this.Controls.Add(this.distanceValue);
			this.Controls.Add(this.magnitudeValue);
			this.Controls.Add(this.magnitudeLabel);
			this.Controls.Add(this.nameValues);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.azText);
			this.Controls.Add(this.altText);
			this.Controls.Add(this.decText);
			this.Controls.Add(this.raText);
			this.Controls.Add(this.thumbnail);
			this.Controls.Add(this.creditsLink);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ObjectProperties";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Black;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ObjectProperties_FormClosed);
			this.Load += new System.EventHandler(this.ObjectProperties_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectProperties_KeyDown);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDoubleClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectProperties_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label decText;
        private System.Windows.Forms.Label raText;
        private System.Windows.Forms.Label altText;
        private System.Windows.Forms.Label azText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label magnitudeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label magnitudeValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label classificationText;
        private System.Windows.Forms.Label distanceValue;
        private System.Windows.Forms.Label azLabel;
        private System.Windows.Forms.Label altLabel;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label raLabel;
        private System.Windows.Forms.Label constellationName;
        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.Timer fadeInTimer;
        private WwtButton research;
        private WwtButton CloseButton;
        private System.Windows.Forms.Label nameValues;
        private System.Windows.Forms.Label creditsText;
        private System.Windows.Forms.Label riseLabel;
        private System.Windows.Forms.Label imageCreditsText;
        private System.Windows.Forms.LinkLabel creditsLink;
        private WwtButton ShowObject;
        private System.Windows.Forms.Label TileBarText;
        private System.Windows.Forms.Label transitLabel;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Label riseText;
        private System.Windows.Forms.Label transitText;
        private System.Windows.Forms.Label setText;
    }
}