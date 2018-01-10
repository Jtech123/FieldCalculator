namespace FieldCalculator
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
            this.TriBtn = new System.Windows.Forms.Button();
            this.SqrBtn = new System.Windows.Forms.Button();
            this.CirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TriBtn
            // 
            this.TriBtn.BackgroundImage = global::FieldCalculator.Properties.Resources.triangleIMG;
            this.TriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TriBtn.Location = new System.Drawing.Point(12, 8);
            this.TriBtn.Name = "TriBtn";
            this.TriBtn.Size = new System.Drawing.Size(200, 377);
            this.TriBtn.TabIndex = 0;
            this.TriBtn.Text = "Rechthoekige driehoek";
            this.TriBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TriBtn.UseVisualStyleBackColor = true;
            this.TriBtn.Click += new System.EventHandler(this.TriBtn_Click);
            // 
            // SqrBtn
            // 
            this.SqrBtn.BackgroundImage = global::FieldCalculator.Properties.Resources.squareIMG;
            this.SqrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SqrBtn.Location = new System.Drawing.Point(218, 8);
            this.SqrBtn.Name = "SqrBtn";
            this.SqrBtn.Size = new System.Drawing.Size(200, 377);
            this.SqrBtn.TabIndex = 1;
            this.SqrBtn.Text = "Rechthoek";
            this.SqrBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SqrBtn.UseVisualStyleBackColor = true;
            this.SqrBtn.Click += new System.EventHandler(this.SqrBtn_Click);
            // 
            // CirBtn
            // 
            this.CirBtn.BackgroundImage = global::FieldCalculator.Properties.Resources.cirlcleIMG;
            this.CirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CirBtn.Location = new System.Drawing.Point(424, 8);
            this.CirBtn.Name = "CirBtn";
            this.CirBtn.Size = new System.Drawing.Size(200, 377);
            this.CirBtn.TabIndex = 2;
            this.CirBtn.Text = "Circel";
            this.CirBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CirBtn.UseVisualStyleBackColor = true;
            this.CirBtn.Click += new System.EventHandler(this.CirBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 397);
            this.Controls.Add(this.CirBtn);
            this.Controls.Add(this.SqrBtn);
            this.Controls.Add(this.TriBtn);
            this.Name = "Form1";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TriBtn;
        private System.Windows.Forms.Button SqrBtn;
        private System.Windows.Forms.Button CirBtn;
    }
}

