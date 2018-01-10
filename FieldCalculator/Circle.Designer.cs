namespace FieldCalculator
{
    partial class Circle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diameterBox = new System.Windows.Forms.TextBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.cirqBox = new System.Windows.Forms.TextBox();
            this.calculateInnerBtn = new System.Windows.Forms.Button();
            this.calculateSidesBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.diameterBox);
            this.panel1.Controls.Add(this.radiusBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 335);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diameter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Straal";
            // 
            // diameterBox
            // 
            this.diameterBox.Location = new System.Drawing.Point(629, 125);
            this.diameterBox.Name = "diameterBox";
            this.diameterBox.Size = new System.Drawing.Size(100, 22);
            this.diameterBox.TabIndex = 3;
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(629, 68);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(100, 22);
            this.radiusBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FieldCalculator.Properties.Resources.cirlcleIMG;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.areaBox);
            this.panel2.Location = new System.Drawing.Point(93, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 271);
            this.panel2.TabIndex = 1;
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(177, 113);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(100, 22);
            this.areaBox.TabIndex = 2;
            // 
            // cirqBox
            // 
            this.cirqBox.Location = new System.Drawing.Point(303, 417);
            this.cirqBox.Name = "cirqBox";
            this.cirqBox.Size = new System.Drawing.Size(100, 22);
            this.cirqBox.TabIndex = 3;
            // 
            // calculateInnerBtn
            // 
            this.calculateInnerBtn.Location = new System.Drawing.Point(363, 36);
            this.calculateInnerBtn.Name = "calculateInnerBtn";
            this.calculateInnerBtn.Size = new System.Drawing.Size(146, 34);
            this.calculateInnerBtn.TabIndex = 13;
            this.calculateInnerBtn.Text = "Bereken Inhoud";
            this.calculateInnerBtn.UseVisualStyleBackColor = true;
            this.calculateInnerBtn.Click += new System.EventHandler(this.CalculateInnerBtn_Click);
            // 
            // calculateSidesBtn
            // 
            this.calculateSidesBtn.Location = new System.Drawing.Point(211, 36);
            this.calculateSidesBtn.Name = "calculateSidesBtn";
            this.calculateSidesBtn.Size = new System.Drawing.Size(146, 34);
            this.calculateSidesBtn.TabIndex = 12;
            this.calculateSidesBtn.Text = "Bereken Omtrek";
            this.calculateSidesBtn.UseVisualStyleBackColor = true;
            this.calculateSidesBtn.Click += new System.EventHandler(this.CalculateSidesBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(690, 513);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 30);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Terug";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inhoud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Omtrek";
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calculateInnerBtn);
            this.Controls.Add(this.calculateSidesBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cirqBox);
            this.Name = "Circle";
            this.Text = "Circle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.TextBox cirqBox;
        private System.Windows.Forms.Button calculateInnerBtn;
        private System.Windows.Forms.Button calculateSidesBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diameterBox;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}