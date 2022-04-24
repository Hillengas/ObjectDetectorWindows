namespace ObjectDetectorUI
{
    partial class FormPictureRecognizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPictureRecognizer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPictureChooser = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnDoML = new System.Windows.Forms.Button();
            this.TxtBoxResultML = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(82, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 295);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPictureChooser
            // 
            this.BtnPictureChooser.Location = new System.Drawing.Point(583, 332);
            this.BtnPictureChooser.Name = "BtnPictureChooser";
            this.BtnPictureChooser.Size = new System.Drawing.Size(119, 23);
            this.BtnPictureChooser.TabIndex = 1;
            this.BtnPictureChooser.Text = "Bild auswählen";
            this.BtnPictureChooser.UseVisualStyleBackColor = true;
            this.BtnPictureChooser.Click += new System.EventHandler(this.BtnPictureChooser_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // BtnDoML
            // 
            this.BtnDoML.Location = new System.Drawing.Point(502, 332);
            this.BtnDoML.Name = "BtnDoML";
            this.BtnDoML.Size = new System.Drawing.Size(75, 23);
            this.BtnDoML.TabIndex = 2;
            this.BtnDoML.Text = "Analysieren";
            this.BtnDoML.UseVisualStyleBackColor = true;
            this.BtnDoML.Click += new System.EventHandler(this.BtnDoML_Click);
            // 
            // TxtBoxResultML
            // 
            this.TxtBoxResultML.Location = new System.Drawing.Point(82, 335);
            this.TxtBoxResultML.Name = "TxtBoxResultML";
            this.TxtBoxResultML.ReadOnly = true;
            this.TxtBoxResultML.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxResultML.TabIndex = 3;
            // 
            // FormPictureRecognizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxResultML);
            this.Controls.Add(this.BtnDoML);
            this.Controls.Add(this.BtnPictureChooser);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPictureRecognizer";
            this.Text = "Kleindungserkennung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPictureChooser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BtnDoML;
        private System.Windows.Forms.TextBox TxtBoxResultML;
    }
}

