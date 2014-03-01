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
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnAuthComplete = new System.Windows.Forms.Button();
            this.txtVerifier = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.prgbarUpload = new System.Windows.Forms.ProgressBar();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(12, 13);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(76, 32);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "認証";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnAuthComplete
            // 
            this.btnAuthComplete.Location = new System.Drawing.Point(12, 76);
            this.btnAuthComplete.Name = "btnAuthComplete";
            this.btnAuthComplete.Size = new System.Drawing.Size(76, 36);
            this.btnAuthComplete.TabIndex = 1;
            this.btnAuthComplete.Text = "完了";
            this.btnAuthComplete.UseVisualStyleBackColor = true;
            this.btnAuthComplete.Click += new System.EventHandler(this.btnAuthComplete_Click);
            // 
            // txtVerifier
            // 
            this.txtVerifier.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtVerifier.Location = new System.Drawing.Point(12, 51);
            this.txtVerifier.Name = "txtVerifier";
            this.txtVerifier.Size = new System.Drawing.Size(190, 19);
            this.txtVerifier.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(12, 284);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(788, 97);
            this.txtResult.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(357, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(76, 32);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "アップロード";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
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
            this.prgbarUpload.Location = new System.Drawing.Point(12, 387);
            this.prgbarUpload.Name = "prgbarUpload";
            this.prgbarUpload.Size = new System.Drawing.Size(788, 34);
            this.prgbarUpload.TabIndex = 5;
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.AllowDrop = true;
            this.txtPhotoPath.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhotoPath.Location = new System.Drawing.Point(357, 51);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(443, 19);
            this.txtPhotoPath.TabIndex = 6;
            this.txtPhotoPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPhotoPath_DragDrop);
            this.txtPhotoPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPhotoPath_DragEnter);
            // 
            // txtTags
            // 
            this.txtTags.AllowDrop = true;
            this.txtTags.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTags.Location = new System.Drawing.Point(357, 76);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(443, 19);
            this.txtTags.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "写真";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "タグ(空白区切り)";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDescription.Location = new System.Drawing.Point(357, 126);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(443, 141);
            this.txtDescription.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "説明";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sets";
            // 
            // txtSets
            // 
            this.txtSets.AllowDrop = true;
            this.txtSets.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSets.Location = new System.Drawing.Point(357, 101);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(443, 19);
            this.txtSets.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.txtPhotoPath);
            this.Controls.Add(this.prgbarUpload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtVerifier);
            this.Controls.Add(this.btnAuthComplete);
            this.Controls.Add(this.btnAuth);
            this.Name = "frmMain";
            this.Text = "Flickr認証";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnAuthComplete;
        private System.Windows.Forms.TextBox txtVerifier;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnUpload;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar prgbarUpload;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSets;
    }
}

