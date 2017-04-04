namespace ImageMagnifier
{
    partial class ImageMagnifier
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picone = new System.Windows.Forms.PictureBox();
            this.pictwo = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.ofdselect = new System.Windows.Forms.OpenFileDialog();
            this.numericCon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).BeginInit();
            this.SuspendLayout();
            // 
            // picone
            // 
            this.picone.Location = new System.Drawing.Point(4, 1);
            this.picone.Name = "picone";
            this.picone.Size = new System.Drawing.Size(332, 404);
            this.picone.TabIndex = 0;
            this.picone.TabStop = false;
            // 
            // pictwo
            // 
            this.pictwo.Location = new System.Drawing.Point(342, 1);
            this.pictwo.Name = "pictwo";
            this.pictwo.Size = new System.Drawing.Size(366, 404);
            this.pictwo.TabIndex = 1;
            this.pictwo.TabStop = false;
            this.pictwo.DoubleClick += new System.EventHandler(this.pictwo_DoubleClick);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(44, 423);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(119, 23);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // numericCon
            // 
            this.numericCon.Location = new System.Drawing.Point(272, 423);
            this.numericCon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCon.Name = "numericCon";
            this.numericCon.Size = new System.Drawing.Size(120, 21);
            this.numericCon.TabIndex = 3;
            this.numericCon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCon.ValueChanged += new System.EventHandler(this.numericCon_ValueChanged);
            // 
            // ImageMagnifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 458);
            this.Controls.Add(this.numericCon);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.pictwo);
            this.Controls.Add(this.picone);
            this.Name = "ImageMagnifier";
            this.Text = "Magnifier";
            ((System.ComponentModel.ISupportInitialize)(this.picone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picone;
        private System.Windows.Forms.PictureBox pictwo;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog ofdselect;
        private System.Windows.Forms.NumericUpDown numericCon;

    }
}

