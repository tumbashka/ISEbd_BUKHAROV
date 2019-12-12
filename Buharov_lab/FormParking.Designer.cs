namespace Buharov_lab
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkingTractor = new System.Windows.Forms.Button();
            this.buttonParkingBulldozer = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeVehicle = new System.Windows.Forms.PictureBox();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(753, 481);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkingTractor
            // 
            this.buttonParkingTractor.Location = new System.Drawing.Point(791, 15);
            this.buttonParkingTractor.Name = "buttonParkingTractor";
            this.buttonParkingTractor.Size = new System.Drawing.Size(91, 46);
            this.buttonParkingTractor.TabIndex = 1;
            this.buttonParkingTractor.Text = "Припарковать трактор";
            this.buttonParkingTractor.UseVisualStyleBackColor = true;
            this.buttonParkingTractor.Click += new System.EventHandler(this.buttonParkingTractor_Click);
            // 
            // buttonParkingBulldozer
            // 
            this.buttonParkingBulldozer.Location = new System.Drawing.Point(791, 67);
            this.buttonParkingBulldozer.Name = "buttonParkingBulldozer";
            this.buttonParkingBulldozer.Size = new System.Drawing.Size(91, 46);
            this.buttonParkingBulldozer.TabIndex = 2;
            this.buttonParkingBulldozer.Text = "Припарковать бульдозер";
            this.buttonParkingBulldozer.UseVisualStyleBackColor = true;
            this.buttonParkingBulldozer.Click += new System.EventHandler(this.buttonParkingBulldozer_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxTakeVehicle);
            this.groupBox.Controls.Add(this.buttonTakeVehicle);
            this.groupBox.Controls.Add(this.maskedTextBox);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(759, 232);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(163, 218);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Забрать машину";
            // 
            // pictureBoxTakeVehicle
            // 
            this.pictureBoxTakeVehicle.Location = new System.Drawing.Point(8, 114);
            this.pictureBoxTakeVehicle.Name = "pictureBoxTakeVehicle";
            this.pictureBoxTakeVehicle.Size = new System.Drawing.Size(149, 103);
            this.pictureBoxTakeVehicle.TabIndex = 3;
            this.pictureBoxTakeVehicle.TabStop = false;
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(32, 83);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(93, 25);
            this.buttonTakeVehicle.TabIndex = 2;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeVehicle_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(73, 39);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(25, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 481);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonParkingBulldozer);
            this.Controls.Add(this.buttonParkingTractor);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingTractor;
        private System.Windows.Forms.Button buttonParkingBulldozer;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBoxTakeVehicle;
    }
}

