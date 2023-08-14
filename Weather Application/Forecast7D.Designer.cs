namespace Weather_Application
{
    partial class Forecast7D
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.DayLable = new System.Windows.Forms.Label();
            this.weathericon = new System.Windows.Forms.PictureBox();
            this.temp = new System.Windows.Forms.Label();
            this.mainDes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weathericon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.DayLable);
            this.panel2.Location = new System.Drawing.Point(0, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 25);
            this.panel2.TabIndex = 0;
            // 
            // DayLable
            // 
            this.DayLable.AutoSize = true;
            this.DayLable.BackColor = System.Drawing.Color.Transparent;
            this.DayLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLable.Location = new System.Drawing.Point(38, 0);
            this.DayLable.Name = "DayLable";
            this.DayLable.Size = new System.Drawing.Size(40, 20);
            this.DayLable.TabIndex = 0;
            this.DayLable.Text = "Day";
            this.DayLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // weathericon
            // 
            this.weathericon.Location = new System.Drawing.Point(27, 44);
            this.weathericon.Name = "weathericon";
            this.weathericon.Size = new System.Drawing.Size(62, 50);
            this.weathericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weathericon.TabIndex = 1;
            this.weathericon.TabStop = false;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(36, 97);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(53, 20);
            this.temp.TabIndex = 1;
            this.temp.Text = "Temp";
            // 
            // mainDes
            // 
            this.mainDes.AutoSize = true;
            this.mainDes.BackColor = System.Drawing.Color.Transparent;
            this.mainDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDes.Location = new System.Drawing.Point(36, 117);
            this.mainDes.Name = "mainDes";
            this.mainDes.Size = new System.Drawing.Size(47, 20);
            this.mainDes.TabIndex = 2;
            this.mainDes.Text = "main";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.mainDes);
            this.panel1.Controls.Add(this.temp);
            this.panel1.Controls.Add(this.weathericon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 150);
            this.panel1.TabIndex = 1;
            // 
            // Forecast7D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Name = "Forecast7D";
            this.Size = new System.Drawing.Size(856, 150);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weathericon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label DayLable;
        public System.Windows.Forms.PictureBox weathericon;
        public System.Windows.Forms.Label temp;
        public System.Windows.Forms.Label mainDes;
        public System.Windows.Forms.Panel panel1;
    }
}
