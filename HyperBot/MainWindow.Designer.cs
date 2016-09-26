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
			this.label1 = new System.Windows.Forms.Label();
			this.picSilver = new System.Windows.Forms.PictureBox();
			this.picYellow = new System.Windows.Forms.PictureBox();
			this.picBlue = new System.Windows.Forms.PictureBox();
			this.picGreen = new System.Windows.Forms.PictureBox();
			this.picRed = new System.Windows.Forms.PictureBox();
			this.picField = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.splTop)).BeginInit();
			this.splTop.Panel1.SuspendLayout();
			this.splTop.Panel2.SuspendLayout();
			this.splTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picSilver)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picYellow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
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
			// splTop.Panel1
			// 
			this.splTop.Panel1.Controls.Add(this.label1);
			this.splTop.Panel1.Controls.Add(this.picSilver);
			this.splTop.Panel1.Controls.Add(this.picYellow);
			this.splTop.Panel1.Controls.Add(this.picBlue);
			this.splTop.Panel1.Controls.Add(this.picGreen);
			this.splTop.Panel1.Controls.Add(this.picRed);
			// 
			// splTop.Panel2
			// 
			this.splTop.Panel2.Controls.Add(this.picField);
			this.splTop.Size = new System.Drawing.Size(767, 543);
			this.splTop.SplitterDistance = 186;
			this.splTop.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 519);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "右クリックで壁配置の\r\n垂直・水平を切り替えます";
			// 
			// picSilver
			// 
			this.picSilver.Location = new System.Drawing.Point(12, 50);
			this.picSilver.Name = "picSilver";
			this.picSilver.Size = new System.Drawing.Size(32, 32);
			this.picSilver.TabIndex = 4;
			this.picSilver.TabStop = false;
			this.picSilver.Paint += new System.Windows.Forms.PaintEventHandler(this.picSilver_Paint);
			this.picSilver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSilver_MouseDown);
			// 
			// picYellow
			// 
			this.picYellow.Location = new System.Drawing.Point(126, 12);
			this.picYellow.Name = "picYellow";
			this.picYellow.Size = new System.Drawing.Size(32, 32);
			this.picYellow.TabIndex = 3;
			this.picYellow.TabStop = false;
			this.picYellow.Paint += new System.Windows.Forms.PaintEventHandler(this.picYellow_Paint);
			this.picYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picYellow_MouseDown);
			// 
			// picBlue
			// 
			this.picBlue.Location = new System.Drawing.Point(88, 12);
			this.picBlue.Name = "picBlue";
			this.picBlue.Size = new System.Drawing.Size(32, 32);
			this.picBlue.TabIndex = 2;
			this.picBlue.TabStop = false;
			this.picBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.picBlue_Paint);
			this.picBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBlue_MouseDown);
			// 
			// picGreen
			// 
			this.picGreen.Location = new System.Drawing.Point(50, 12);
			this.picGreen.Name = "picGreen";
			this.picGreen.Size = new System.Drawing.Size(32, 32);
			this.picGreen.TabIndex = 1;
			this.picGreen.TabStop = false;
			this.picGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.picGreen_Paint);
			this.picGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picGreen_MouseDown);
			// 
			// picRed
			// 
			this.picRed.Location = new System.Drawing.Point(12, 12);
			this.picRed.Name = "picRed";
			this.picRed.Size = new System.Drawing.Size(32, 32);
			this.picRed.TabIndex = 0;
			this.picRed.TabStop = false;
			this.picRed.Paint += new System.Windows.Forms.PaintEventHandler(this.picRed_Paint);
			this.picRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picRed_MouseDown);
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
			this.picField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picField_MouseDown);
			this.picField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picField_MouseMove);
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
			this.Text = "ハイパーボッ　…と";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
			this.splTop.Panel1.ResumeLayout(false);
			this.splTop.Panel1.PerformLayout();
			this.splTop.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splTop)).EndInit();
			this.splTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picSilver)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picYellow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picField)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.SplitContainer splTop;
		private System.Windows.Forms.PictureBox picField;
		private System.Windows.Forms.PictureBox picRed;
		private System.Windows.Forms.PictureBox picYellow;
		private System.Windows.Forms.PictureBox picBlue;
		private System.Windows.Forms.PictureBox picGreen;
		private System.Windows.Forms.PictureBox picSilver;
		private System.Windows.Forms.Label label1;
	}
}

