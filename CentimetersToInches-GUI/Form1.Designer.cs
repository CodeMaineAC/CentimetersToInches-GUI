
namespace CentimetersToInches_GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inchesBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputToCentimeters = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.centimeterBox = new System.Windows.Forms.TextBox();
            this.conversionButton = new System.Windows.Forms.Button();
            this.convToInchesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(33, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inches";
            // 
            // inchesBox
            // 
            this.inchesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchesBox.Location = new System.Drawing.Point(38, 182);
            this.inchesBox.Multiline = true;
            this.inchesBox.Name = "inchesBox";
            this.inchesBox.Size = new System.Drawing.Size(100, 33);
            this.inchesBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(240, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Centimeters";
            // 
            // OutputToCentimeters
            // 
            this.OutputToCentimeters.AutoSize = true;
            this.OutputToCentimeters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputToCentimeters.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.OutputToCentimeters.Location = new System.Drawing.Point(68, 314);
            this.OutputToCentimeters.Name = "OutputToCentimeters";
            this.OutputToCentimeters.Size = new System.Drawing.Size(70, 26);
            this.OutputToCentimeters.TabIndex = 5;
            this.OutputToCentimeters.Text = "label3";
            this.OutputToCentimeters.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // centimeterBox
            // 
            this.centimeterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centimeterBox.Location = new System.Drawing.Point(245, 182);
            this.centimeterBox.Multiline = true;
            this.centimeterBox.Name = "centimeterBox";
            this.centimeterBox.Size = new System.Drawing.Size(100, 33);
            this.centimeterBox.TabIndex = 7;
            // 
            // conversionButton
            // 
            this.conversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionButton.Location = new System.Drawing.Point(38, 237);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(142, 41);
            this.conversionButton.TabIndex = 8;
            this.conversionButton.Text = "Convert to CM";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.conversionButton_Click);
            // 
            // convToInchesButton
            // 
            this.convToInchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convToInchesButton.Location = new System.Drawing.Point(245, 237);
            this.convToInchesButton.Name = "convToInchesButton";
            this.convToInchesButton.Size = new System.Drawing.Size(142, 41);
            this.convToInchesButton.TabIndex = 9;
            this.convToInchesButton.Text = "Convert to In";
            this.convToInchesButton.UseVisualStyleBackColor = true;
            this.convToInchesButton.Click += new System.EventHandler(this.convToInchesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convToInchesButton);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.centimeterBox);
            this.Controls.Add(this.OutputToCentimeters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inchesBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Centimeter To Inches";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inchesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputToCentimeters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox centimeterBox;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.Button convToInchesButton;
    }
}

