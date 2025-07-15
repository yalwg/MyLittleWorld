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
            this.pictureBox = new System.Windows.Forms.PictureBox();
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartRotation = new System.Windows.Forms.Button();
            this.btnStopRotation = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxSkyBrush = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteMode = new System.Windows.Forms.Button();
            this.buttonBuildMode = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.boxSpeedControl = new System.Windows.Forms.GroupBox();
            this.boxRadiusControl = new System.Windows.Forms.GroupBox();
            this.boxSkyColor = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.boxBuildMode.SuspendLayout();
            this.boxBuildObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.boxSkyBrush.SuspendLayout();
            this.boxSpeedControl.SuspendLayout();
            this.boxRadiusControl.SuspendLayout();
            this.boxSkyColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(14, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(741, 675);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
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
            this.btnClear.Location = new System.Drawing.Point(967, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(6, 21);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(377, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 157;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "250";
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "100 (влево)";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "100 (вправо)";
            // 
            // boxSkyBrush
            // 
            this.boxSkyBrush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSkyBrush.Controls.Add(this.radioButton2);
            this.boxSkyBrush.Controls.Add(this.radioButton1);
            this.boxSkyBrush.Location = new System.Drawing.Point(967, 13);
            this.boxSkyBrush.Name = "boxSkyBrush";
            this.boxSkyBrush.Size = new System.Drawing.Size(183, 149);
            this.boxSkyBrush.TabIndex = 16;
            this.boxSkyBrush.TabStop = false;
            this.boxSkyBrush.Text = "Небо";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Красивое...";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Штриховка";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            // 
            // buttonDeleteMode
            // 
            this.buttonDeleteMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteMode.Location = new System.Drawing.Point(967, 168);
            this.buttonDeleteMode.Name = "buttonDeleteMode";
            this.buttonDeleteMode.Size = new System.Drawing.Size(183, 43);
            this.buttonDeleteMode.TabIndex = 18;
            this.buttonDeleteMode.Text = "Режим удаления";
            this.buttonDeleteMode.UseVisualStyleBackColor = true;
            this.buttonDeleteMode.Click += new System.EventHandler(this.buttonDeleteMode_Click);
            // 
            // buttonBuildMode
            // 
            this.buttonBuildMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuildMode.BackColor = System.Drawing.Color.LightGreen;
            this.buttonBuildMode.Location = new System.Drawing.Point(967, 217);
            this.buttonBuildMode.Name = "buttonBuildMode";
            this.buttonBuildMode.Size = new System.Drawing.Size(183, 43);
            this.buttonBuildMode.TabIndex = 19;
            this.buttonBuildMode.Text = "Режим строительства";
            this.buttonBuildMode.UseVisualStyleBackColor = false;
            this.buttonBuildMode.Click += new System.EventHandler(this.buttonBuildMode_Click);
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
            this.boxSpeedControl.Controls.Add(this.label4);
            this.boxSpeedControl.Controls.Add(this.label5);
            this.boxSpeedControl.Controls.Add(this.label7);
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
            this.boxRadiusControl.Controls.Add(this.trackBar1);
            this.boxRadiusControl.Controls.Add(this.label1);
            this.boxRadiusControl.Controls.Add(this.label2);
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
            this.Controls.Add(this.buttonBuildMode);
            this.Controls.Add(this.buttonDeleteMode);
            this.Controls.Add(this.boxSkyBrush);
            this.Controls.Add(this.btnStopRotation);
            this.Controls.Add(this.btnStartRotation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.boxBuildObjects);
            this.Controls.Add(this.boxBuildMode);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(930, 704);
            this.Name = "MainForm";
            this.Text = "My Little World";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.boxBuildMode.ResumeLayout(false);
            this.boxBuildMode.PerformLayout();
            this.boxBuildObjects.ResumeLayout(false);
            this.boxBuildObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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

        private PictureBox pictureBox;
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
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Button btnStartRotation;
        private Button btnStopRotation;
        private TrackBar trackBarSpeed;
        private Label label4;
        private Label label5;
        private GroupBox boxSkyBrush;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private Button buttonDeleteMode;
        private Button buttonBuildMode;
        private Button btnColor2;
        private GroupBox boxSpeedControl;
        private GroupBox boxRadiusControl;
        private GroupBox boxSkyColor;
    }
}