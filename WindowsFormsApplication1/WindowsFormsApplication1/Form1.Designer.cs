namespace WindowsFormsApplication1
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.FW = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(285, 20);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(50, 50);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            // 
            // FW
            // 
            this.FW.AccumBits = ((byte)(0));
            this.FW.AutoCheckErrors = false;
            this.FW.AutoFinish = false;
            this.FW.AutoMakeCurrent = true;
            this.FW.AutoSwapBuffers = true;
            this.FW.BackColor = System.Drawing.Color.Black;
            this.FW.ColorBits = ((byte)(32));
            this.FW.DepthBits = ((byte)(16));
            this.FW.Location = new System.Drawing.Point(0, 0);
            this.FW.Name = "FW";
            this.FW.Size = new System.Drawing.Size(284, 258);
            this.FW.StencilBits = ((byte)(0));
            this.FW.TabIndex = 1;
            this.FW.Load += new System.EventHandler(this.simpleOpenGlControl2_Load);
            this.FW.Paint += new System.Windows.Forms.PaintEventHandler(this.FW_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FW);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private Tao.Platform.Windows.SimpleOpenGlControl FW;
    }
}

