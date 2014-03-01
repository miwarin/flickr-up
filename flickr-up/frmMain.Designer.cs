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
            this.SuspendLayout();
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(47, 31);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(298, 53);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "認証";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthComplete
            // 
            this.btnAuthComplete.Location = new System.Drawing.Point(47, 115);
            this.btnAuthComplete.Name = "btnAuthComplete";
            this.btnAuthComplete.Size = new System.Drawing.Size(298, 53);
            this.btnAuthComplete.TabIndex = 1;
            this.btnAuthComplete.Text = "完了";
            this.btnAuthComplete.UseVisualStyleBackColor = true;
            this.btnAuthComplete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVerifier
            // 
            this.txtVerifier.Location = new System.Drawing.Point(47, 90);
            this.txtVerifier.Name = "txtVerifier";
            this.txtVerifier.Size = new System.Drawing.Size(298, 19);
            this.txtVerifier.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(47, 174);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(298, 196);
            this.txtResult.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 394);
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
    }
}

