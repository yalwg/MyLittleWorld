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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMountains = new System.Windows.Forms.RadioButton();
            this.radioObelisk = new System.Windows.Forms.RadioButton();
            this.radioFir = new System.Windows.Forms.RadioButton();
            this.radioHouse = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMountainsCount = new System.Windows.Forms.Label();
            this.lblObeliskCount = new System.Windows.Forms.Label();
            this.lblFirCount = new System.Windows.Forms.Label();
            this.lblHouseCount = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.pictureBox.Size = new System.Drawing.Size(685, 640);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioMountains);
            this.groupBox1.Controls.Add(this.radioObelisk);
            this.groupBox1.Controls.Add(this.radioFir);
            this.groupBox1.Controls.Add(this.radioHouse);
            this.groupBox1.Location = new System.Drawing.Point(706, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblMountainsCount);
            this.groupBox2.Controls.Add(this.lblObeliskCount);
            this.groupBox2.Controls.Add(this.lblFirCount);
            this.groupBox2.Controls.Add(this.lblHouseCount);
            this.groupBox2.Location = new System.Drawing.Point(706, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество объектов";
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
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.Location = new System.Drawing.Point(706, 324);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(194, 43);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Цвет неба";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(706, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистить все";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(716, 455);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(176, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "250";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Радиус планеты:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 666);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(930, 704);
            this.Name = "MainForm";
            this.Text = "My Little World";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private GroupBox groupBox1;
        private RadioButton radioMountains;
        private RadioButton radioObelisk;
        private RadioButton radioFir;
        private RadioButton radioHouse;
        private GroupBox groupBox2;
        private Label lblMountainsCount;
        private Label lblObeliskCount;
        private Label lblFirCount;
        private Label lblHouseCount;
        private Button btnColor;
        private Button btnClear;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}