namespace 高速GridView
{
    partial class Form高速GridView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn検索 = new System.Windows.Forms.Button();
            this.dtp終了 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始 = new System.Windows.Forms.DateTimePicker();
            this.lbl件数 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel進捗 = new System.Windows.Forms.Panel();
            this.textBox進捗 = new System.Windows.Forms.TextBox();
            this.button閉じる = new System.Windows.Forms.Button();
            this.button進捗 = new System.Windows.Forms.Button();
            this.panelロード中 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel進捗.SuspendLayout();
            this.panelロード中.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn検索
            // 
            this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn検索.Location = new System.Drawing.Point(558, 13);
            this.btn検索.Margin = new System.Windows.Forms.Padding(4);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(125, 35);
            this.btn検索.TabIndex = 6;
            this.btn検索.TabStop = false;
            this.btn検索.Text = "検索";
            this.btn検索.UseVisualStyleBackColor = true;
            this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
            // 
            // dtp終了
            // 
            this.dtp終了.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp終了.Location = new System.Drawing.Point(304, 14);
            this.dtp終了.Margin = new System.Windows.Forms.Padding(4);
            this.dtp終了.Name = "dtp終了";
            this.dtp終了.Size = new System.Drawing.Size(236, 34);
            this.dtp終了.TabIndex = 5;
            // 
            // dtp開始
            // 
            this.dtp開始.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp開始.Location = new System.Drawing.Point(13, 13);
            this.dtp開始.Margin = new System.Windows.Forms.Padding(4);
            this.dtp開始.Name = "dtp開始";
            this.dtp開始.Size = new System.Drawing.Size(236, 34);
            this.dtp開始.TabIndex = 4;
            // 
            // lbl件数
            // 
            this.lbl件数.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl件数.ForeColor = System.Drawing.Color.Red;
            this.lbl件数.Location = new System.Drawing.Point(730, 13);
            this.lbl件数.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl件数.Name = "lbl件数";
            this.lbl件数.Size = new System.Drawing.Size(223, 30);
            this.lbl件数.TabIndex = 41;
            this.lbl件数.Text = "0 件";
            this.lbl件数.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(218)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(13, 55);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 36;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1440, 893);
            this.dataGridView.TabIndex = 47;
            // 
            // panel進捗
            // 
            this.panel進捗.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel進捗.Controls.Add(this.panelロード中);
            this.panel進捗.Controls.Add(this.button閉じる);
            this.panel進捗.Controls.Add(this.textBox進捗);
            this.panel進捗.Location = new System.Drawing.Point(288, 128);
            this.panel進捗.Name = "panel進捗";
            this.panel進捗.Size = new System.Drawing.Size(882, 699);
            this.panel進捗.TabIndex = 49;
            // 
            // textBox進捗
            // 
            this.textBox進捗.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox進捗.Font = new System.Drawing.Font("MS UI Gothic", 15.75F);
            this.textBox進捗.Location = new System.Drawing.Point(16, 15);
            this.textBox進捗.Multiline = true;
            this.textBox進捗.Name = "textBox進捗";
            this.textBox進捗.Size = new System.Drawing.Size(847, 620);
            this.textBox進捗.TabIndex = 49;
            // 
            // button閉じる
            // 
            this.button閉じる.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button閉じる.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button閉じる.Location = new System.Drawing.Point(373, 651);
            this.button閉じる.Margin = new System.Windows.Forms.Padding(4);
            this.button閉じる.Name = "button閉じる";
            this.button閉じる.Size = new System.Drawing.Size(125, 35);
            this.button閉じる.TabIndex = 51;
            this.button閉じる.TabStop = false;
            this.button閉じる.Text = "閉じる";
            this.button閉じる.UseVisualStyleBackColor = true;
            this.button閉じる.Click += new System.EventHandler(this.button閉じる_Click);
            // 
            // button進捗
            // 
            this.button進捗.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button進捗.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button進捗.Location = new System.Drawing.Point(1328, 13);
            this.button進捗.Margin = new System.Windows.Forms.Padding(4);
            this.button進捗.Name = "button進捗";
            this.button進捗.Size = new System.Drawing.Size(125, 35);
            this.button進捗.TabIndex = 51;
            this.button進捗.TabStop = false;
            this.button進捗.Text = "進捗表示";
            this.button進捗.UseVisualStyleBackColor = true;
            this.button進捗.Click += new System.EventHandler(this.button進捗_Click);
            // 
            // panelロード中
            // 
            this.panelロード中.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelロード中.BackColor = System.Drawing.Color.White;
            this.panelロード中.Controls.Add(this.pictureBox1);
            this.panelロード中.Controls.Add(this.label1);
            this.panelロード中.Controls.Add(this.label2);
            this.panelロード中.Location = new System.Drawing.Point(211, 264);
            this.panelロード中.Name = "panelロード中";
            this.panelロード中.Size = new System.Drawing.Size(460, 170);
            this.panelロード中.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::高速GridView.Properties.Resources.Loading_icon;
            this.pictureBox1.Location = new System.Drawing.Point(349, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "ロード中です...";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 140);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(257, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 30);
            this.label3.TabIndex = 52;
            this.label3.Text = "～";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form高速GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 954);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button進捗);
            this.Controls.Add(this.panel進捗);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbl件数);
            this.Controls.Add(this.btn検索);
            this.Controls.Add(this.dtp終了);
            this.Controls.Add(this.dtp開始);
            this.Name = "Form高速GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高速GridView";
            this.Load += new System.EventHandler(this.Form高速GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel進捗.ResumeLayout(false);
            this.panel進捗.PerformLayout();
            this.panelロード中.ResumeLayout(false);
            this.panelロード中.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn検索;
        private System.Windows.Forms.DateTimePicker dtp終了;
        private System.Windows.Forms.DateTimePicker dtp開始;
        private System.Windows.Forms.Label lbl件数;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel進捗;
        private System.Windows.Forms.Button button閉じる;
        private System.Windows.Forms.TextBox textBox進捗;
        private System.Windows.Forms.Button button進捗;
        private System.Windows.Forms.Panel panelロード中;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

