
namespace Teme
{
    partial class Tema9_PartitionarePoligoaneMonotone
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonFinishUp = new System.Windows.Forms.Button();
            this.buttonPartiton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 396);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "DrawMode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFinishUp
            // 
            this.buttonFinishUp.Enabled = false;
            this.buttonFinishUp.Location = new System.Drawing.Point(746, 50);
            this.buttonFinishUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinishUp.Name = "buttonFinishUp";
            this.buttonFinishUp.Size = new System.Drawing.Size(88, 27);
            this.buttonFinishUp.TabIndex = 2;
            this.buttonFinishUp.Text = "FinishUp";
            this.buttonFinishUp.UseVisualStyleBackColor = true;
            this.buttonFinishUp.Click += new System.EventHandler(this.buttonFinishUp_Click);
            // 
            // buttonPartiton
            // 
            this.buttonPartiton.Enabled = false;
            this.buttonPartiton.Location = new System.Drawing.Point(744, 83);
            this.buttonPartiton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPartiton.Name = "buttonPartiton";
            this.buttonPartiton.Size = new System.Drawing.Size(88, 27);
            this.buttonPartiton.TabIndex = 3;
            this.buttonPartiton.Text = "Partition";
            this.buttonPartiton.UseVisualStyleBackColor = true;
            this.buttonPartiton.Click += new System.EventHandler(this.buttonPartiton_Click);
            // 
            // Tema9_PartitionarePoligoaneMonotone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 423);
            this.Controls.Add(this.buttonPartiton);
            this.Controls.Add(this.buttonFinishUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Tema9_PartitionarePoligoaneMonotone";
            this.Text = "FormPartPoligMontone";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonFinishUp;
        private System.Windows.Forms.Button buttonPartiton;
    }
}

