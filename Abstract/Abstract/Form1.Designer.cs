namespace Abstract
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
            this.btnGitar = new System.Windows.Forms.Button();
            this.btnKeman = new System.Windows.Forms.Button();
            this.btnBateri = new System.Windows.Forms.Button();
            this.btnMac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGitar
            // 
            this.btnGitar.Location = new System.Drawing.Point(165, 52);
            this.btnGitar.Name = "btnGitar";
            this.btnGitar.Size = new System.Drawing.Size(75, 23);
            this.btnGitar.TabIndex = 0;
            this.btnGitar.Text = "GitarCal";
            this.btnGitar.UseVisualStyleBackColor = true;
            this.btnGitar.Click += new System.EventHandler(this.btnGitar_Click);
            // 
            // btnKeman
            // 
            this.btnKeman.Location = new System.Drawing.Point(330, 51);
            this.btnKeman.Name = "btnKeman";
            this.btnKeman.Size = new System.Drawing.Size(75, 23);
            this.btnKeman.TabIndex = 1;
            this.btnKeman.Text = "KemanCal";
            this.btnKeman.UseVisualStyleBackColor = true;
            this.btnKeman.Click += new System.EventHandler(this.btnKeman_Click);
            // 
            // btnBateri
            // 
            this.btnBateri.Location = new System.Drawing.Point(165, 117);
            this.btnBateri.Name = "btnBateri";
            this.btnBateri.Size = new System.Drawing.Size(75, 23);
            this.btnBateri.TabIndex = 2;
            this.btnBateri.Text = "BateriCal";
            this.btnBateri.UseVisualStyleBackColor = true;
            this.btnBateri.Click += new System.EventHandler(this.btnBateri_Click);
            // 
            // btnMac
            // 
            this.btnMac.Location = new System.Drawing.Point(344, 140);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(148, 23);
            this.btnMac.TabIndex = 3;
            this.btnMac.Text = "MuzikAletiCal";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMac);
            this.Controls.Add(this.btnBateri);
            this.Controls.Add(this.btnKeman);
            this.Controls.Add(this.btnGitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGitar;
        private System.Windows.Forms.Button btnKeman;
        private System.Windows.Forms.Button btnBateri;
        private System.Windows.Forms.Button btnMac;
    }
}

