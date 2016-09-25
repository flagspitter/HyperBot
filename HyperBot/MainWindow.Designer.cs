namespace HyperBot
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.splTop = new System.Windows.Forms.SplitContainer();
			this.picField = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.splTop)).BeginInit();
			this.splTop.Panel2.SuspendLayout();
			this.splTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picField)).BeginInit();
			this.SuspendLayout();
			// 
			// splTop
			// 
			this.splTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splTop.IsSplitterFixed = true;
			this.splTop.Location = new System.Drawing.Point(0, 0);
			this.splTop.Name = "splTop";
			// 
			// splTop.Panel2
			// 
			this.splTop.Panel2.Controls.Add(this.picField);
			this.splTop.Size = new System.Drawing.Size(767, 543);
			this.splTop.SplitterDistance = 186;
			this.splTop.TabIndex = 0;
			// 
			// picField
			// 
			this.picField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picField.Location = new System.Drawing.Point(0, 0);
			this.picField.Name = "picField";
			this.picField.Size = new System.Drawing.Size(577, 543);
			this.picField.TabIndex = 0;
			this.picField.TabStop = false;
			this.picField.Paint += new System.Windows.Forms.PaintEventHandler(this.picField_Paint);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 543);
			this.Controls.Add(this.splTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "ハイパーボッ";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
			this.splTop.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splTop)).EndInit();
			this.splTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picField)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.SplitContainer splTop;
		private System.Windows.Forms.PictureBox picField;
	}
}

