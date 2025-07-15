using System.Drawing;
using System.Windows.Forms;

namespace MyLittleWorld
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.planetSystemPictureBox = new System.Windows.Forms.PictureBox();
            this.boxBuildMode = new System.Windows.Forms.GroupBox();
            this.radioMountains = new System.Windows.Forms.RadioButton();
            this.radioObelisk = new System.Windows.Forms.RadioButton();
            this.radioFir = new System.Windows.Forms.RadioButton();
            this.radioHouse = new System.Windows.Forms.RadioButton();
            this.boxBuildObjects = new System.Windows.Forms.GroupBox();
            this.lblMountainsCount = new System.Windows.Forms.Label();
            this.lblObeliskCount = new System.Windows.Forms.Label();
            this.lblFirCount = new System.Windows.Forms.Label();
            this.lblHouseCount = new System.Windows.Forms.Label();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            this.lblMinRadius = new System.Windows.Forms.Label();
            this.lblMaxRadius = new System.Windows.Forms.Label();
            this.btnStartRotation = new System.Windows.Forms.Button();
            this.btnStopRotation = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.lblMinSpeed = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.boxSkyBrush = new System.Windows.Forms.GroupBox();
            this.radioCustomBrush = new System.Windows.Forms.RadioButton();
            this.radioHatchBrush = new System.Windows.Forms.RadioButton();
            this.lblNullSpeed = new System.Windows.Forms.Label();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnBuildMode = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.boxSpeedControl = new System.Windows.Forms.GroupBox();
            this.boxRadiusControl = new System.Windows.Forms.GroupBox();
            this.boxSkyColor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.planetSystemPictureBox)).BeginInit();
            this.boxBuildMode.SuspendLayout();
            this.boxBuildObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.boxSkyBrush.SuspendLayout();
            this.boxSpeedControl.SuspendLayout();
            this.boxRadiusControl.SuspendLayout();
            this.boxSkyColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // planetSystemPictureBox
            // 
            this.planetSystemPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planetSystemPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.planetSystemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planetSystemPictureBox.Location = new System.Drawing.Point(14, 13);
            this.planetSystemPictureBox.Name = "planetSystemPictureBox";
            this.planetSystemPictureBox.Size = new System.Drawing.Size(741, 675);
            this.planetSystemPictureBox.TabIndex = 0;
            this.planetSystemPictureBox.TabStop = false;
            this.planetSystemPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.planetSystemPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // boxBuildMode
            // 
            this.boxBuildMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxBuildMode.Controls.Add(this.radioMountains);
            this.boxBuildMode.Controls.Add(this.radioObelisk);
            this.boxBuildMode.Controls.Add(this.radioFir);
            this.boxBuildMode.Controls.Add(this.radioHouse);
            this.boxBuildMode.Location = new System.Drawing.Point(761, 13);
            this.boxBuildMode.Name = "boxBuildMode";
            this.boxBuildMode.Size = new System.Drawing.Size(194, 149);
            this.boxBuildMode.TabIndex = 1;
            this.boxBuildMode.TabStop = false;
            this.boxBuildMode.Text = "Добавить";
            // 
            // radioMountains
            // 
            this.radioMountains.AutoSize = true;
            this.radioMountains.Location = new System.Drawing.Point(7, 118);
            this.radioMountains.Name = "radioMountains";
            this.radioMountains.Size = new System.Drawing.Size(59, 20);
            this.radioMountains.TabIndex = 3;
            this.radioMountains.TabStop = true;
            this.radioMountains.Text = "Гора";
            this.radioMountains.UseVisualStyleBackColor = true;
            this.radioMountains.CheckedChanged += new System.EventHandler(this.radioMountains_CheckedChanged);
            // 
            // radioObelisk
            // 
            this.radioObelisk.AutoSize = true;
            this.radioObelisk.Location = new System.Drawing.Point(7, 92);
            this.radioObelisk.Name = "radioObelisk";
            this.radioObelisk.Size = new System.Drawing.Size(84, 20);
            this.radioObelisk.TabIndex = 2;
            this.radioObelisk.TabStop = true;
            this.radioObelisk.Text = "Обелиск";
            this.radioObelisk.UseVisualStyleBackColor = true;
            this.radioObelisk.CheckedChanged += new System.EventHandler(this.radioObelisk_CheckedChanged);
            // 
            // radioFir
            // 
            this.radioFir.AutoSize = true;
            this.radioFir.Location = new System.Drawing.Point(7, 65);
            this.radioFir.Name = "radioFir";
            this.radioFir.Size = new System.Drawing.Size(62, 20);
            this.radioFir.TabIndex = 1;
            this.radioFir.TabStop = true;
            this.radioFir.Text = "Елка";
            this.radioFir.UseVisualStyleBackColor = true;
            this.radioFir.CheckedChanged += new System.EventHandler(this.radioFir_CheckedChanged);
            // 
            // radioHouse
            // 
            this.radioHouse.AutoSize = true;
            this.radioHouse.Location = new System.Drawing.Point(7, 38);
            this.radioHouse.Name = "radioHouse";
            this.radioHouse.Size = new System.Drawing.Size(69, 20);
            this.radioHouse.TabIndex = 0;
            this.radioHouse.TabStop = true;
            this.radioHouse.Text = "Домик";
            this.radioHouse.UseVisualStyleBackColor = true;
            this.radioHouse.CheckedChanged += new System.EventHandler(this.radioHouse_CheckedChanged);
            // 
            // boxBuildObjects
            // 
            this.boxBuildObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxBuildObjects.Controls.Add(this.lblMountainsCount);
            this.boxBuildObjects.Controls.Add(this.lblObeliskCount);
            this.boxBuildObjects.Controls.Add(this.lblFirCount);
            this.boxBuildObjects.Controls.Add(this.lblHouseCount);
            this.boxBuildObjects.Location = new System.Drawing.Point(761, 168);
            this.boxBuildObjects.Name = "boxBuildObjects";
            this.boxBuildObjects.Size = new System.Drawing.Size(194, 138);
            this.boxBuildObjects.TabIndex = 2;
            this.boxBuildObjects.TabStop = false;
            this.boxBuildObjects.Text = "Количество объектов";
            // 
            // lblMountainsCount
            // 
            this.lblMountainsCount.AutoSize = true;
            this.lblMountainsCount.Location = new System.Drawing.Point(7, 118);
            this.lblMountainsCount.Name = "lblMountainsCount";
            this.lblMountainsCount.Size = new System.Drawing.Size(51, 16);
            this.lblMountainsCount.TabIndex = 3;
            this.lblMountainsCount.Text = "Гора: 0";
            // 
            // lblObeliskCount
            // 
            this.lblObeliskCount.AutoSize = true;
            this.lblObeliskCount.Location = new System.Drawing.Point(7, 92);
            this.lblObeliskCount.Name = "lblObeliskCount";
            this.lblObeliskCount.Size = new System.Drawing.Size(76, 16);
            this.lblObeliskCount.TabIndex = 2;
            this.lblObeliskCount.Text = "Обелиск: 0";
            // 
            // lblFirCount
            // 
            this.lblFirCount.AutoSize = true;
            this.lblFirCount.Location = new System.Drawing.Point(7, 65);
            this.lblFirCount.Name = "lblFirCount";
            this.lblFirCount.Size = new System.Drawing.Size(54, 16);
            this.lblFirCount.TabIndex = 1;
            this.lblFirCount.Text = "Елка: 0";
            // 
            // lblHouseCount
            // 
            this.lblHouseCount.AutoSize = true;
            this.lblHouseCount.Location = new System.Drawing.Point(7, 38);
            this.lblHouseCount.Name = "lblHouseCount";
            this.lblHouseCount.Size = new System.Drawing.Size(61, 16);
            this.lblHouseCount.TabIndex = 0;
            this.lblHouseCount.Text = "Домик: 0";
            // 
            // btnColor1
            // 
            this.btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor1.Location = new System.Drawing.Point(7, 21);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(181, 43);
            this.btnColor1.TabIndex = 3;
            this.btnColor1.Text = "Цвет неба #1";
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(967, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 124);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRadius.Location = new System.Drawing.Point(6, 21);
            this.trackBarRadius.Maximum = 250;
            this.trackBarRadius.Minimum = 10;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(377, 56);
            this.trackBarRadius.TabIndex = 0;
            this.trackBarRadius.Value = 157;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblMinRadius
            // 
            this.lblMinRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinRadius.AutoSize = true;
            this.lblMinRadius.Location = new System.Drawing.Point(4, 80);
            this.lblMinRadius.Name = "lblMinRadius";
            this.lblMinRadius.Size = new System.Drawing.Size(21, 16);
            this.lblMinRadius.TabIndex = 7;
            this.lblMinRadius.Text = "10";
            // 
            // lblMaxRadius
            // 
            this.lblMaxRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxRadius.AutoSize = true;
            this.lblMaxRadius.Location = new System.Drawing.Point(355, 80);
            this.lblMaxRadius.Name = "lblMaxRadius";
            this.lblMaxRadius.Size = new System.Drawing.Size(28, 16);
            this.lblMaxRadius.TabIndex = 8;
            this.lblMaxRadius.Text = "250";
            // 
            // btnStartRotation
            // 
            this.btnStartRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartRotation.Location = new System.Drawing.Point(1090, 579);
            this.btnStartRotation.Name = "btnStartRotation";
            this.btnStartRotation.Size = new System.Drawing.Size(75, 54);
            this.btnStartRotation.TabIndex = 10;
            this.btnStartRotation.Text = "Старт";
            this.btnStartRotation.UseVisualStyleBackColor = true;
            this.btnStartRotation.Click += new System.EventHandler(this.btnStartRotation_Click);
            // 
            // btnStopRotation
            // 
            this.btnStopRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopRotation.Location = new System.Drawing.Point(1090, 639);
            this.btnStopRotation.Name = "btnStopRotation";
            this.btnStopRotation.Size = new System.Drawing.Size(75, 49);
            this.btnStopRotation.TabIndex = 11;
            this.btnStopRotation.Text = "Стоп";
            this.btnStopRotation.UseVisualStyleBackColor = true;
            this.btnStopRotation.Click += new System.EventHandler(this.btnStopRotation_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSpeed.Location = new System.Drawing.Point(9, 21);
            this.trackBarSpeed.Maximum = 100;
            this.trackBarSpeed.Minimum = -100;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(315, 56);
            this.trackBarSpeed.TabIndex = 12;
            this.trackBarSpeed.Value = 10;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // lblMinSpeed
            // 
            this.lblMinSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinSpeed.AutoSize = true;
            this.lblMinSpeed.Location = new System.Drawing.Point(12, 80);
            this.lblMinSpeed.Name = "lblMinSpeed";
            this.lblMinSpeed.Size = new System.Drawing.Size(79, 16);
            this.lblMinSpeed.TabIndex = 13;
            this.lblMinSpeed.Text = "100 (влево)";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(232, 80);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(87, 16);
            this.lblMaxSpeed.TabIndex = 14;
            this.lblMaxSpeed.Text = "100 (вправо)";
            // 
            // boxSkyBrush
            // 
            this.boxSkyBrush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSkyBrush.Controls.Add(this.radioCustomBrush);
            this.boxSkyBrush.Controls.Add(this.radioHatchBrush);
            this.boxSkyBrush.Location = new System.Drawing.Point(967, 13);
            this.boxSkyBrush.Name = "boxSkyBrush";
            this.boxSkyBrush.Size = new System.Drawing.Size(183, 149);
            this.boxSkyBrush.TabIndex = 16;
            this.boxSkyBrush.TabStop = false;
            this.boxSkyBrush.Text = "Небо";
            // 
            // radioCustomBrush
            // 
            this.radioCustomBrush.AutoSize = true;
            this.radioCustomBrush.Location = new System.Drawing.Point(6, 65);
            this.radioCustomBrush.Name = "radioCustomBrush";
            this.radioCustomBrush.Size = new System.Drawing.Size(100, 20);
            this.radioCustomBrush.TabIndex = 5;
            this.radioCustomBrush.Text = "Красивое...";
            this.radioCustomBrush.UseVisualStyleBackColor = true;
            this.radioCustomBrush.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioHatchBrush
            // 
            this.radioHatchBrush.AutoSize = true;
            this.radioHatchBrush.Checked = true;
            this.radioHatchBrush.Location = new System.Drawing.Point(6, 38);
            this.radioHatchBrush.Name = "radioHatchBrush";
            this.radioHatchBrush.Size = new System.Drawing.Size(99, 20);
            this.radioHatchBrush.TabIndex = 4;
            this.radioHatchBrush.TabStop = true;
            this.radioHatchBrush.Text = "Штриховка";
            this.radioHatchBrush.UseVisualStyleBackColor = true;
            this.radioHatchBrush.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblNullSpeed
            // 
            this.lblNullSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNullSpeed.AutoSize = true;
            this.lblNullSpeed.Location = new System.Drawing.Point(159, 80);
            this.lblNullSpeed.Name = "lblNullSpeed";
            this.lblNullSpeed.Size = new System.Drawing.Size(14, 16);
            this.lblNullSpeed.TabIndex = 17;
            this.lblNullSpeed.Text = "0";
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMode.Location = new System.Drawing.Point(967, 168);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(183, 69);
            this.btnDeleteMode.TabIndex = 18;
            this.btnDeleteMode.Text = "Режим удаления";
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.buttonDeleteMode_Click);
            // 
            // btnBuildMode
            // 
            this.btnBuildMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildMode.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuildMode.Location = new System.Drawing.Point(967, 237);
            this.btnBuildMode.Name = "btnBuildMode";
            this.btnBuildMode.Size = new System.Drawing.Size(183, 69);
            this.btnBuildMode.TabIndex = 19;
            this.btnBuildMode.Text = "Режим строительства";
            this.btnBuildMode.UseVisualStyleBackColor = false;
            this.btnBuildMode.Click += new System.EventHandler(this.buttonBuildMode_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor2.Location = new System.Drawing.Point(7, 70);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(181, 43);
            this.btnColor2.TabIndex = 20;
            this.btnColor2.Text = "Цвет неба #2";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // boxSpeedControl
            // 
            this.boxSpeedControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSpeedControl.Controls.Add(this.trackBarSpeed);
            this.boxSpeedControl.Controls.Add(this.lblMinSpeed);
            this.boxSpeedControl.Controls.Add(this.lblMaxSpeed);
            this.boxSpeedControl.Controls.Add(this.lblNullSpeed);
            this.boxSpeedControl.Location = new System.Drawing.Point(760, 579);
            this.boxSpeedControl.Name = "boxSpeedControl";
            this.boxSpeedControl.Size = new System.Drawing.Size(325, 110);
            this.boxSpeedControl.TabIndex = 21;
            this.boxSpeedControl.TabStop = false;
            this.boxSpeedControl.Text = "Скорость вращения (в градусах/сек)";
            // 
            // boxRadiusControl
            // 
            this.boxRadiusControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxRadiusControl.Controls.Add(this.trackBarRadius);
            this.boxRadiusControl.Controls.Add(this.lblMinRadius);
            this.boxRadiusControl.Controls.Add(this.lblMaxRadius);
            this.boxRadiusControl.Location = new System.Drawing.Point(761, 452);
            this.boxRadiusControl.Name = "boxRadiusControl";
            this.boxRadiusControl.Size = new System.Drawing.Size(389, 100);
            this.boxRadiusControl.TabIndex = 22;
            this.boxRadiusControl.TabStop = false;
            this.boxRadiusControl.Text = "Радиус планеты (в пикселях)";
            // 
            // boxSkyColor
            // 
            this.boxSkyColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSkyColor.Controls.Add(this.btnColor1);
            this.boxSkyColor.Controls.Add(this.btnColor2);
            this.boxSkyColor.Location = new System.Drawing.Point(761, 312);
            this.boxSkyColor.Name = "boxSkyColor";
            this.boxSkyColor.Size = new System.Drawing.Size(194, 134);
            this.boxSkyColor.TabIndex = 23;
            this.boxSkyColor.TabStop = false;
            this.boxSkyColor.Text = "Цвет неба";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 701);
            this.Controls.Add(this.boxSkyColor);
            this.Controls.Add(this.boxRadiusControl);
            this.Controls.Add(this.boxSpeedControl);
            this.Controls.Add(this.btnBuildMode);
            this.Controls.Add(this.btnDeleteMode);
            this.Controls.Add(this.boxSkyBrush);
            this.Controls.Add(this.btnStopRotation);
            this.Controls.Add(this.btnStartRotation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.boxBuildObjects);
            this.Controls.Add(this.boxBuildMode);
            this.Controls.Add(this.planetSystemPictureBox);
            this.MinimumSize = new System.Drawing.Size(930, 704);
            this.Name = "MainForm";
            this.Text = "My Little World";
            ((System.ComponentModel.ISupportInitialize)(this.planetSystemPictureBox)).EndInit();
            this.boxBuildMode.ResumeLayout(false);
            this.boxBuildMode.PerformLayout();
            this.boxBuildObjects.ResumeLayout(false);
            this.boxBuildObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.boxSkyBrush.ResumeLayout(false);
            this.boxSkyBrush.PerformLayout();
            this.boxSpeedControl.ResumeLayout(false);
            this.boxSpeedControl.PerformLayout();
            this.boxRadiusControl.ResumeLayout(false);
            this.boxRadiusControl.PerformLayout();
            this.boxSkyColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox planetSystemPictureBox;
        private GroupBox boxBuildMode;
        private RadioButton radioMountains;
        private RadioButton radioObelisk;
        private RadioButton radioFir;
        private RadioButton radioHouse;
        private GroupBox boxBuildObjects;
        private Label lblMountainsCount;
        private Label lblObeliskCount;
        private Label lblFirCount;
        private Label lblHouseCount;
        private Button btnColor1;
        private Button btnClear;
        private TrackBar trackBarRadius;
        private Label lblMinRadius;
        private Label lblMaxRadius;
        private Button btnStartRotation;
        private Button btnStopRotation;
        private TrackBar trackBarSpeed;
        private Label lblMinSpeed;
        private Label lblMaxSpeed;
        private GroupBox boxSkyBrush;
        private RadioButton radioCustomBrush;
        private RadioButton radioHatchBrush;
        private Label lblNullSpeed;
        private Button btnDeleteMode;
        private Button btnBuildMode;
        private Button btnColor2;
        private GroupBox boxSpeedControl;
        private GroupBox boxRadiusControl;
        private GroupBox boxSkyColor;
    }
}