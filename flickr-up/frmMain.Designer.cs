namespace flickr_up
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.prgbarUpload = new System.Windows.Forms.ProgressBar();
            this.tabFlickr = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSecret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerifier = new System.Windows.Forms.TextBox();
            this.btnAuthComplete = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.tabUpload = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tabImageMagick = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIMConvertPath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWorkDirectory = new System.Windows.Forms.TextBox();
            this.tabFlickr.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabUpload.SuspendLayout();
            this.tabImageMagick.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(12, 320);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(576, 87);
            this.txtResult.TabIndex = 3;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // prgbarUpload
            // 
            this.prgbarUpload.Location = new System.Drawing.Point(12, 413);
            this.prgbarUpload.Name = "prgbarUpload";
            this.prgbarUpload.Size = new System.Drawing.Size(576, 22);
            this.prgbarUpload.TabIndex = 5;
            // 
            // tabFlickr
            // 
            this.tabFlickr.Controls.Add(this.tabAuth);
            this.tabFlickr.Controls.Add(this.tabUpload);
            this.tabFlickr.Controls.Add(this.tabImageMagick);
            this.tabFlickr.Location = new System.Drawing.Point(12, 12);
            this.tabFlickr.Name = "tabFlickr";
            this.tabFlickr.SelectedIndex = 0;
            this.tabFlickr.Size = new System.Drawing.Size(576, 302);
            this.tabFlickr.TabIndex = 15;
            // 
            // tabAuth
            // 
            this.tabAuth.Controls.Add(this.label7);
            this.tabAuth.Controls.Add(this.txtSecret);
            this.tabAuth.Controls.Add(this.label6);
            this.tabAuth.Controls.Add(this.txtAPIKey);
            this.tabAuth.Controls.Add(this.label5);
            this.tabAuth.Controls.Add(this.txtVerifier);
            this.tabAuth.Controls.Add(this.btnAuthComplete);
            this.tabAuth.Controls.Add(this.btnAuth);
            this.tabAuth.Location = new System.Drawing.Point(4, 22);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuth.Size = new System.Drawing.Size(568, 276);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "認証";
            this.tabAuth.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Secret";
            // 
            // txtSecret
            // 
            this.txtSecret.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSecret.Location = new System.Drawing.Point(68, 40);
            this.txtSecret.Name = "txtSecret";
            this.txtSecret.Size = new System.Drawing.Size(466, 19);
            this.txtSecret.TabIndex = 9;
            this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "APIKey";
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAPIKey.Location = new System.Drawing.Point(68, 15);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(466, 19);
            this.txtAPIKey.TabIndex = 7;
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "認証コード";
            // 
            // txtVerifier
            // 
            this.txtVerifier.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtVerifier.Location = new System.Drawing.Point(68, 145);
            this.txtVerifier.Name = "txtVerifier";
            this.txtVerifier.Size = new System.Drawing.Size(466, 19);
            this.txtVerifier.TabIndex = 5;
            // 
            // btnAuthComplete
            // 
            this.btnAuthComplete.Location = new System.Drawing.Point(6, 167);
            this.btnAuthComplete.Name = "btnAuthComplete";
            this.btnAuthComplete.Size = new System.Drawing.Size(76, 36);
            this.btnAuthComplete.TabIndex = 4;
            this.btnAuthComplete.Text = "完了";
            this.btnAuthComplete.UseVisualStyleBackColor = true;
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(6, 104);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(76, 32);
            this.btnAuth.TabIndex = 3;
            this.btnAuth.Text = "認証";
            this.btnAuth.UseVisualStyleBackColor = true;
            // 
            // tabUpload
            // 
            this.tabUpload.Controls.Add(this.label4);
            this.tabUpload.Controls.Add(this.txtSets);
            this.tabUpload.Controls.Add(this.label1);
            this.tabUpload.Controls.Add(this.txtDescription);
            this.tabUpload.Controls.Add(this.label3);
            this.tabUpload.Controls.Add(this.label2);
            this.tabUpload.Controls.Add(this.txtTags);
            this.tabUpload.Controls.Add(this.txtPhotoPath);
            this.tabUpload.Controls.Add(this.btnUpload);
            this.tabUpload.Location = new System.Drawing.Point(4, 22);
            this.tabUpload.Name = "tabUpload";
            this.tabUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpload.Size = new System.Drawing.Size(568, 276);
            this.tabUpload.TabIndex = 1;
            this.tabUpload.Text = "アップロード";
            this.tabUpload.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sets";
            // 
            // txtSets
            // 
            this.txtSets.AllowDrop = true;
            this.txtSets.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSets.Location = new System.Drawing.Point(101, 131);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(443, 19);
            this.txtSets.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "説明";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDescription.Location = new System.Drawing.Point(101, 156);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(443, 87);
            this.txtDescription.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "タグ(空白区切り)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "写真";
            // 
            // txtTags
            // 
            this.txtTags.AllowDrop = true;
            this.txtTags.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTags.Location = new System.Drawing.Point(101, 106);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(443, 19);
            this.txtTags.TabIndex = 17;
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.AllowDrop = true;
            this.txtPhotoPath.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhotoPath.Location = new System.Drawing.Point(101, 56);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(443, 19);
            this.txtPhotoPath.TabIndex = 16;
            this.txtPhotoPath.TextChanged += new System.EventHandler(this.txtPhotoPath_TextChanged);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(101, 17);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(76, 32);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "アップロード";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tabImageMagick
            // 
            this.tabImageMagick.Controls.Add(this.label10);
            this.tabImageMagick.Controls.Add(this.txtWorkDirectory);
            this.tabImageMagick.Controls.Add(this.label9);
            this.tabImageMagick.Controls.Add(this.txtResize);
            this.tabImageMagick.Controls.Add(this.label8);
            this.tabImageMagick.Controls.Add(this.txtIMConvertPath);
            this.tabImageMagick.Location = new System.Drawing.Point(4, 22);
            this.tabImageMagick.Name = "tabImageMagick";
            this.tabImageMagick.Size = new System.Drawing.Size(568, 276);
            this.tabImageMagick.TabIndex = 2;
            this.tabImageMagick.Text = "ImageMagick";
            this.tabImageMagick.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "ImageMagick convert path";
            // 
            // txtIMConvertPath
            // 
            this.txtIMConvertPath.AllowDrop = true;
            this.txtIMConvertPath.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtIMConvertPath.Location = new System.Drawing.Point(79, 41);
            this.txtIMConvertPath.Name = "txtIMConvertPath";
            this.txtIMConvertPath.Size = new System.Drawing.Size(443, 19);
            this.txtIMConvertPath.TabIndex = 19;
            this.txtIMConvertPath.TextChanged += new System.EventHandler(this.txtIMConvertPath_TextChanged);
            this.txtIMConvertPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtIMConvertPath_DragDrop);
            this.txtIMConvertPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtIMConvertPath_DragEnter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "倍率(%)";
            // 
            // txtResize
            // 
            this.txtResize.AllowDrop = true;
            this.txtResize.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResize.Location = new System.Drawing.Point(79, 66);
            this.txtResize.Name = "txtResize";
            this.txtResize.Size = new System.Drawing.Size(443, 19);
            this.txtResize.TabIndex = 26;
            this.txtResize.TextChanged += new System.EventHandler(this.txtResize_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "作業フォルダ";
            // 
            // txtWorkDirectory
            // 
            this.txtWorkDirectory.AllowDrop = true;
            this.txtWorkDirectory.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWorkDirectory.Location = new System.Drawing.Point(79, 91);
            this.txtWorkDirectory.Name = "txtWorkDirectory";
            this.txtWorkDirectory.Size = new System.Drawing.Size(443, 19);
            this.txtWorkDirectory.TabIndex = 28;
            this.txtWorkDirectory.TextChanged += new System.EventHandler(this.txtWorkDirectory_TextChanged);
            this.txtWorkDirectory.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtWorkDirectory_DragDrop);
            this.txtWorkDirectory.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtWorkDirectory_DragEnter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.tabFlickr);
            this.Controls.Add(this.prgbarUpload);
            this.Controls.Add(this.txtResult);
            this.Name = "frmMain";
            this.Text = "Flickrうｐ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabFlickr.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabUpload.ResumeLayout(false);
            this.tabUpload.PerformLayout();
            this.tabImageMagick.ResumeLayout(false);
            this.tabImageMagick.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar prgbarUpload;
        private System.Windows.Forms.TabControl tabFlickr;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.TabPage tabUpload;
        private System.Windows.Forms.TextBox txtVerifier;
        private System.Windows.Forms.Button btnAuthComplete;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TabPage tabImageMagick;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIMConvertPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWorkDirectory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResize;
    }
}

