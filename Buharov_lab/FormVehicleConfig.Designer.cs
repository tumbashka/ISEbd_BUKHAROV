namespace Buharov_lab
{
    partial class FormVehicleConfig
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
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelBulldozer = new System.Windows.Forms.Label();
            this.labelTractor = new System.Windows.Forms.Label();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelVehicle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(12, 14);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(139, 89);
            this.pictureBoxTakeCar.TabIndex = 0;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelBulldozer);
            this.groupBox1.Controls.Add(this.labelTractor);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelBulldozer
            // 
            this.labelBulldozer.AllowDrop = true;
            this.labelBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBulldozer.Location = new System.Drawing.Point(6, 75);
            this.labelBulldozer.Name = "labelBulldozer";
            this.labelBulldozer.Size = new System.Drawing.Size(132, 39);
            this.labelBulldozer.TabIndex = 1;
            this.labelBulldozer.Text = "Бульдозер";
            this.labelBulldozer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelBulldozer_MouseDown);
            // 
            // labelTractor
            // 
            this.labelTractor.AllowDrop = true;
            this.labelTractor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTractor.Location = new System.Drawing.Point(6, 27);
            this.labelTractor.Name = "labelTractor";
            this.labelTractor.Size = new System.Drawing.Size(132, 39);
            this.labelTractor.TabIndex = 0;
            this.labelTractor.Text = "Трактор";
            this.labelTractor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTractor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTractor_MouseDown);
            // 
            // panelVehicle
            // 
            this.panelVehicle.AllowDrop = true;
            this.panelVehicle.Controls.Add(this.labelDopColor);
            this.panelVehicle.Controls.Add(this.pictureBoxTakeCar);
            this.panelVehicle.Controls.Add(this.labelBaseColor);
            this.panelVehicle.Location = new System.Drawing.Point(188, 26);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(164, 208);
            this.panelVehicle.TabIndex = 2;
            this.panelVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelVehicle_DragDrop);
            this.panelVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelVehicle_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(12, 163);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(139, 29);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(12, 117);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(139, 29);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelFuchsia);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(358, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.AllowDrop = true;
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(72, 142);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 36);
            this.panelOrange.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(72, 100);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 36);
            this.panelYellow.TabIndex = 2;
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.AllowDrop = true;
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(13, 142);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(38, 36);
            this.panelFuchsia.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(13, 100);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 36);
            this.panelRed.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(72, 58);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 36);
            this.panelBlue.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.LimeGreen;
            this.panelGreen.Location = new System.Drawing.Point(13, 58);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 36);
            this.panelGreen.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(72, 14);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(38, 36);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(13, 16);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 36);
            this.panelBlack.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(27, 204);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 30);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 255);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelVehicle);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelVehicle.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBulldozer;
        private System.Windows.Forms.Label labelTractor;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}