namespace CannyHough {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.load_source = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.source_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadimg_button = new System.Windows.Forms.Button();
            this.OtsuText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_source
            // 
            this.load_source.Location = new System.Drawing.Point(941, 14);
            this.load_source.Name = "load_source";
            this.load_source.Size = new System.Drawing.Size(30, 23);
            this.load_source.TabIndex = 0;
            this.load_source.Text = "...";
            this.load_source.UseVisualStyleBackColor = true;
            this.load_source.Click += new System.EventHandler(this.load_source_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 43);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(959, 523);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // source_txtbox
            // 
            this.source_txtbox.Location = new System.Drawing.Point(12, 14);
            this.source_txtbox.Name = "source_txtbox";
            this.source_txtbox.Size = new System.Drawing.Size(923, 20);
            this.source_txtbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apply Transform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadimg_button
            // 
            this.loadimg_button.Location = new System.Drawing.Point(996, 165);
            this.loadimg_button.Name = "loadimg_button";
            this.loadimg_button.Size = new System.Drawing.Size(123, 21);
            this.loadimg_button.TabIndex = 9;
            this.loadimg_button.Text = "Load Img";
            this.loadimg_button.UseVisualStyleBackColor = true;
            this.loadimg_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // OtsuText
            // 
            this.OtsuText.Location = new System.Drawing.Point(999, 249);
            this.OtsuText.Name = "OtsuText";
            this.OtsuText.Size = new System.Drawing.Size(53, 20);
            this.OtsuText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Otsu Threshold";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(996, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 21);
            this.button3.TabIndex = 15;
            this.button3.Text = "Select Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(996, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bulk Processing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(993, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Single Processing";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(996, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 21);
            this.button2.TabIndex = 18;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 601);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtsuText);
            this.Controls.Add(this.loadimg_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.source_txtbox);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.load_source);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_source;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox source_txtbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadimg_button;
        private System.Windows.Forms.TextBox OtsuText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

