namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ksifretxt = new System.Windows.Forms.TextBox();
            this.postatxt = new System.Windows.Forms.TextBox();
            this.telefontxt = new System.Windows.Forms.TextBox();
            this.kullaniciadtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ksifretxt);
            this.panel2.Controls.Add(this.postatxt);
            this.panel2.Controls.Add(this.telefontxt);
            this.panel2.Controls.Add(this.kullaniciadtxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(33, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 398);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(276, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDOL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ksifretxt
            // 
            this.ksifretxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ksifretxt.Location = new System.Drawing.Point(276, 204);
            this.ksifretxt.Name = "ksifretxt";
            this.ksifretxt.Size = new System.Drawing.Size(116, 20);
            this.ksifretxt.TabIndex = 4;
            this.ksifretxt.Text = "Şifre";
            // 
            // postatxt
            // 
            this.postatxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.postatxt.Location = new System.Drawing.Point(276, 178);
            this.postatxt.Name = "postatxt";
            this.postatxt.Size = new System.Drawing.Size(116, 20);
            this.postatxt.TabIndex = 3;
            this.postatxt.Text = "E-posta";
            // 
            // telefontxt
            // 
            this.telefontxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.telefontxt.Location = new System.Drawing.Point(276, 152);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(116, 20);
            this.telefontxt.TabIndex = 2;
            this.telefontxt.Text = "Telefon";
            // 
            // kullaniciadtxt
            // 
            this.kullaniciadtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.kullaniciadtxt.Location = new System.Drawing.Point(276, 126);
            this.kullaniciadtxt.Name = "kullaniciadtxt";
            this.kullaniciadtxt.Size = new System.Drawing.Size(116, 20);
            this.kullaniciadtxt.TabIndex = 1;
            this.kullaniciadtxt.Text = "Kullanıcı Adı";
            this.kullaniciadtxt.TextChanged += new System.EventHandler(this.kullaniciadtxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(283, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAYDOL";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(276, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 447);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ksifretxt;
        private System.Windows.Forms.TextBox postatxt;
        private System.Windows.Forms.TextBox telefontxt;
        private System.Windows.Forms.TextBox kullaniciadtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}