namespace VB1_Book_Sales_Calculator
{
    partial class calculatorForm
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorForm));
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.totalDueLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Blue;
            label1.Location = new System.Drawing.Point(80, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(280, 32);
            label1.TabIndex = 1;
            label1.Text = "Book Sales";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facePictureBox
            // 
            this.facePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("facePictureBox.Image")));
            this.facePictureBox.Location = new System.Drawing.Point(8, 8);
            this.facePictureBox.Name = "facePictureBox";
            this.facePictureBox.Size = new System.Drawing.Size(50, 50);
            this.facePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facePictureBox.TabIndex = 0;
            this.facePictureBox.TabStop = false;
            // 
            // salesTextBox
            // 
            this.salesTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTextBox.Location = new System.Drawing.Point(72, 96);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.Size = new System.Drawing.Size(80, 22);
            this.salesTextBox.TabIndex = 0;
            this.salesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codeComboBox
            // 
            this.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Items.AddRange(new object[] {
            "None",
            "Student",
            "Faculty",
            "Staff",
            "Special"});
            this.codeComboBox.Location = new System.Drawing.Point(176, 96);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(80, 24);
            this.codeComboBox.TabIndex = 1;
            // 
            // percentLabel
            // 
            this.percentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.Location = new System.Drawing.Point(280, 96);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(80, 23);
            this.percentLabel.TabIndex = 4;
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // discountLabel
            // 
            this.discountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountLabel.Location = new System.Drawing.Point(72, 160);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(80, 23);
            this.discountLabel.TabIndex = 5;
            this.discountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesLabel
            // 
            this.salesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(176, 160);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(80, 23);
            this.salesLabel.TabIndex = 6;
            this.salesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDueLabel
            // 
            this.totalDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDueLabel.Location = new System.Drawing.Point(280, 160);
            this.totalDueLabel.Name = "totalDueLabel";
            this.totalDueLabel.Size = new System.Drawing.Size(80, 23);
            this.totalDueLabel.TabIndex = 7;
            this.totalDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sales";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Percent";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Discount";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Sales Tax";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(280, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Due";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(72, 216);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(176, 216);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(280, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Created by Jenny Nguyen";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 281);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalDueLabel);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.salesTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.facePictureBox);
            this.Name = "calculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Sales Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label totalDueLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label12;
    }
}

