namespace Teme
{
    partial class Tema8_TriangulareOtectomie
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
            this.buttonDrawMode = new System.Windows.Forms.Button();
            this.buttonFinishUp = new System.Windows.Forms.Button();
            this.buttonTriang = new System.Windows.Forms.Button();
            this.buttonThreeColor = new System.Windows.Forms.Button();
            this.buttonArie = new System.Windows.Forms.Button();
            this.labelArie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 370);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonDrawMode
            // 
            this.buttonDrawMode.Location = new System.Drawing.Point(709, 9);
            this.buttonDrawMode.Name = "buttonDrawMode";
            this.buttonDrawMode.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawMode.TabIndex = 1;
            this.buttonDrawMode.Text = "DrawMode";
            this.buttonDrawMode.UseVisualStyleBackColor = true;
            this.buttonDrawMode.Click += new System.EventHandler(this.buttonDrawMode_Click);
            // 
            // buttonFinishUp
            // 
            this.buttonFinishUp.Location = new System.Drawing.Point(709, 38);
            this.buttonFinishUp.Name = "buttonFinishUp";
            this.buttonFinishUp.Size = new System.Drawing.Size(75, 23);
            this.buttonFinishUp.TabIndex = 2;
            this.buttonFinishUp.Text = "FinishUp";
            this.buttonFinishUp.UseVisualStyleBackColor = true;
            this.buttonFinishUp.Click += new System.EventHandler(this.buttonFinishUp_Click);
            // 
            // buttonTriang
            // 
            this.buttonTriang.Location = new System.Drawing.Point(709, 67);
            this.buttonTriang.Name = "buttonTriang";
            this.buttonTriang.Size = new System.Drawing.Size(75, 23);
            this.buttonTriang.TabIndex = 3;
            this.buttonTriang.Text = "Triangulate";
            this.buttonTriang.UseVisualStyleBackColor = true;
            this.buttonTriang.Click += new System.EventHandler(this.buttonTriang_Click);
            // 
            // buttonThreeColor
            // 
            this.buttonThreeColor.Location = new System.Drawing.Point(709, 96);
            this.buttonThreeColor.Name = "buttonThreeColor";
            this.buttonThreeColor.Size = new System.Drawing.Size(75, 23);
            this.buttonThreeColor.TabIndex = 4;
            this.buttonThreeColor.Text = "3Color";
            this.buttonThreeColor.UseVisualStyleBackColor = true;
            this.buttonThreeColor.Click += new System.EventHandler(this.buttonThreeColor_Click);
            // 
            // buttonArie
            // 
            this.buttonArie.Location = new System.Drawing.Point(709, 125);
            this.buttonArie.Name = "buttonArie";
            this.buttonArie.Size = new System.Drawing.Size(75, 23);
            this.buttonArie.TabIndex = 5;
            this.buttonArie.Text = "GetArea";
            this.buttonArie.UseVisualStyleBackColor = true;
            this.buttonArie.Click += new System.EventHandler(this.buttonArie_Click);
            // 
            // labelArie
            // 
            this.labelArie.AutoSize = true;
            this.labelArie.Location = new System.Drawing.Point(709, 151);
            this.labelArie.Name = "labelArie";
            this.labelArie.Size = new System.Drawing.Size(0, 15);
            this.labelArie.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Triangles";
            // 
            // TriangulareOtectomie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelArie);
            this.Controls.Add(this.buttonArie);
            this.Controls.Add(this.buttonThreeColor);
            this.Controls.Add(this.buttonTriang);
            this.Controls.Add(this.buttonFinishUp);
            this.Controls.Add(this.buttonDrawMode);
            this.Controls.Add(this.panel1);
            this.Name = "TriangulareOtectomie";
            this.Text = "TriangulareOtectomie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button buttonDrawMode;
        private Button buttonFinishUp;
        private Button buttonTriang;
        private Button buttonThreeColor;
        private Button buttonArie;
        private Label labelArie;
        private Label label1;
    }
}