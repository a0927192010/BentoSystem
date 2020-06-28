namespace III便當店_NEW
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
            this.btn值日生 = new System.Windows.Forms.Button();
            this.btn學員 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn值日生
            // 
            this.btn值日生.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn值日生.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn值日生.Location = new System.Drawing.Point(144, 93);
            this.btn值日生.Name = "btn值日生";
            this.btn值日生.Size = new System.Drawing.Size(286, 132);
            this.btn值日生.TabIndex = 0;
            this.btn值日生.Text = "值日生";
            this.btn值日生.UseVisualStyleBackColor = false;
            this.btn值日生.Click += new System.EventHandler(this.btn值日生_Click);
            // 
            // btn學員
            // 
            this.btn學員.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn學員.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn學員.Location = new System.Drawing.Point(144, 271);
            this.btn學員.Name = "btn學員";
            this.btn學員.Size = new System.Drawing.Size(286, 132);
            this.btn學員.TabIndex = 1;
            this.btn學員.Text = "學員";
            this.btn學員.UseVisualStyleBackColor = false;
            this.btn學員.Click += new System.EventHandler(this.btn學員_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 520);
            this.Controls.Add(this.btn學員);
            this.Controls.Add(this.btn值日生);
            this.Name = "Form1";
            this.Text = "今天想吃甚麼兒";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn值日生;
        private System.Windows.Forms.Button btn學員;
    }
}