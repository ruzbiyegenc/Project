namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bandroltxt = new System.Windows.Forms.TextBox();
            this.turtxt = new System.Windows.Forms.TextBox();
            this.tarihtxt = new System.Windows.Forms.TextBox();
            this.kitaptxt = new System.Windows.Forms.TextBox();
            this.fiyattxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.fiyattxt);
            this.panel2.Controls.Add(this.kitaptxt);
            this.panel2.Controls.Add(this.tarihtxt);
            this.panel2.Controls.Add(this.turtxt);
            this.panel2.Controls.Add(this.bandroltxt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(128, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 382);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "KİTAP EKLE";
            // 
            // bandroltxt
            // 
            this.bandroltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bandroltxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bandroltxt.Location = new System.Drawing.Point(91, 84);
            this.bandroltxt.Name = "bandroltxt";
            this.bandroltxt.Size = new System.Drawing.Size(142, 24);
            this.bandroltxt.TabIndex = 3;
            this.bandroltxt.Text = "Bandrol No";
            // 
            // turtxt
            // 
            this.turtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.turtxt.Location = new System.Drawing.Point(91, 164);
            this.turtxt.Name = "turtxt";
            this.turtxt.Size = new System.Drawing.Size(142, 24);
            this.turtxt.TabIndex = 4;
            this.turtxt.Text = "Tür";
            // 
            // tarihtxt
            // 
            this.tarihtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarihtxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tarihtxt.Location = new System.Drawing.Point(91, 204);
            this.tarihtxt.Name = "tarihtxt";
            this.tarihtxt.Size = new System.Drawing.Size(142, 24);
            this.tarihtxt.TabIndex = 5;
            this.tarihtxt.Text = "Basım Tarihi";
            // 
            // kitaptxt
            // 
            this.kitaptxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitaptxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.kitaptxt.Location = new System.Drawing.Point(91, 124);
            this.kitaptxt.Name = "kitaptxt";
            this.kitaptxt.Size = new System.Drawing.Size(142, 24);
            this.kitaptxt.TabIndex = 6;
            this.kitaptxt.Text = "Kitap Adi";
            // 
            // fiyattxt
            // 
            this.fiyattxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyattxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fiyattxt.Location = new System.Drawing.Point(91, 245);
            this.fiyattxt.Name = "fiyattxt";
            this.fiyattxt.Size = new System.Drawing.Size(142, 24);
            this.fiyattxt.TabIndex = 7;
            this.fiyattxt.Text = "Fiyat";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(111, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fiyattxt;
        private System.Windows.Forms.TextBox kitaptxt;
        private System.Windows.Forms.TextBox tarihtxt;
        private System.Windows.Forms.TextBox turtxt;
        private System.Windows.Forms.TextBox bandroltxt;
        private System.Windows.Forms.Button button2;
    }
}