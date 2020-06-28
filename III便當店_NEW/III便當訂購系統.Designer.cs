namespace III便當店_NEW
{
    partial class III便當訂購系統
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn訂單刪除 = new System.Windows.Forms.Button();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.tb數量 = new System.Windows.Forms.TextBox();
            this.btn加 = new System.Windows.Forms.Button();
            this.btn加入訂單 = new System.Windows.Forms.Button();
            this.btn減 = new System.Windows.Forms.Button();
            this.cb品名 = new System.Windows.Forms.ComboBox();
            this.cb店家 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb姓名 = new System.Windows.Forms.ComboBox();
            this.cb期別 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb值日生 = new System.Windows.Forms.Label();
            this.btn學員資料 = new System.Windows.Forms.Button();
            this.btn廠商資料 = new System.Windows.Forms.Button();
            this.btn菜單 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet = new III便當店_NEW._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn菜單資料維護 = new System.Windows.Forms.Button();
            this.order_detailTableAdapter = new III便當店_NEW._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSetTableAdapters.order_detailTableAdapter();
            this.lbl時間 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl份數總價 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl時間2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "店家";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn訂單刪除);
            this.groupBox1.Controls.Add(this.lbl單價);
            this.groupBox1.Controls.Add(this.tb數量);
            this.groupBox1.Controls.Add(this.btn加);
            this.groupBox1.Controls.Add(this.btn加入訂單);
            this.groupBox1.Controls.Add(this.btn減);
            this.groupBox1.Controls.Add(this.cb品名);
            this.groupBox1.Controls.Add(this.cb店家);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "訂購單";
            // 
            // btn訂單刪除
            // 
            this.btn訂單刪除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單刪除.Location = new System.Drawing.Point(318, 176);
            this.btn訂單刪除.Name = "btn訂單刪除";
            this.btn訂單刪除.Size = new System.Drawing.Size(126, 44);
            this.btn訂單刪除.TabIndex = 13;
            this.btn訂單刪除.Text = "訂單刪除";
            this.btn訂單刪除.UseVisualStyleBackColor = true;
            this.btn訂單刪除.Click += new System.EventHandler(this.btn訂單刪除_Click);
            // 
            // lbl單價
            // 
            this.lbl單價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl單價.Location = new System.Drawing.Point(110, 236);
            this.lbl單價.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(194, 44);
            this.lbl單價.TabIndex = 12;
            this.lbl單價.Text = "0";
            this.lbl單價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb數量
            // 
            this.tb數量.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb數量.Location = new System.Drawing.Point(171, 176);
            this.tb數量.Name = "tb數量";
            this.tb數量.Size = new System.Drawing.Size(67, 45);
            this.tb數量.TabIndex = 8;
            this.tb數量.TextChanged += new System.EventHandler(this.tb數量_TextChanged);
            // 
            // btn加
            // 
            this.btn加.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加.Location = new System.Drawing.Point(244, 176);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(63, 50);
            this.btn加.TabIndex = 7;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = true;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn加入訂單
            // 
            this.btn加入訂單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂單.Location = new System.Drawing.Point(318, 236);
            this.btn加入訂單.Name = "btn加入訂單";
            this.btn加入訂單.Size = new System.Drawing.Size(126, 44);
            this.btn加入訂單.TabIndex = 11;
            this.btn加入訂單.Text = "加入訂單";
            this.btn加入訂單.UseVisualStyleBackColor = true;
            this.btn加入訂單.Click += new System.EventHandler(this.btn加入訂單_Click);
            // 
            // btn減
            // 
            this.btn減.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn減.Location = new System.Drawing.Point(106, 176);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(62, 50);
            this.btn減.TabIndex = 6;
            this.btn減.Text = "-";
            this.btn減.UseVisualStyleBackColor = true;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // cb品名
            // 
            this.cb品名.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb品名.FormattingEnabled = true;
            this.cb品名.Location = new System.Drawing.Point(110, 116);
            this.cb品名.Name = "cb品名";
            this.cb品名.Size = new System.Drawing.Size(192, 44);
            this.cb品名.TabIndex = 5;
            this.cb品名.SelectedIndexChanged += new System.EventHandler(this.cb品名_SelectedIndexChanged);
            // 
            // cb店家
            // 
            this.cb店家.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb店家.FormattingEnabled = true;
            this.cb店家.Location = new System.Drawing.Point(110, 62);
            this.cb店家.Name = "cb店家";
            this.cb店家.Size = new System.Drawing.Size(192, 44);
            this.cb店家.TabIndex = 4;
            this.cb店家.SelectedIndexChanged += new System.EventHandler(this.cb店家_SelectedIndexChanged);
            this.cb店家.SelectionChangeCommitted += new System.EventHandler(this.cb店家_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(22, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "單價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(22, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "數量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "品名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb姓名);
            this.groupBox2.Controls.Add(this.cb期別);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(476, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "學員資料";
            // 
            // cb姓名
            // 
            this.cb姓名.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb姓名.FormattingEnabled = true;
            this.cb姓名.Location = new System.Drawing.Point(140, 81);
            this.cb姓名.Name = "cb姓名";
            this.cb姓名.Size = new System.Drawing.Size(152, 44);
            this.cb姓名.TabIndex = 7;
            // 
            // cb期別
            // 
            this.cb期別.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb期別.FormattingEnabled = true;
            this.cb期別.Location = new System.Drawing.Point(140, 32);
            this.cb期別.Name = "cb期別";
            this.cb期別.Size = new System.Drawing.Size(152, 44);
            this.cb期別.TabIndex = 6;
            this.cb期別.SelectedIndexChanged += new System.EventHandler(this.cb期別_SelectedIndexChanged);
            this.cb期別.SelectionChangeCommitted += new System.EventHandler(this.cb期別_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "學員姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(30, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "期別";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(832, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "值日生:";
            // 
            // lb值日生
            // 
            this.lb值日生.AutoSize = true;
            this.lb值日生.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb值日生.Location = new System.Drawing.Point(956, 106);
            this.lb值日生.Name = "lb值日生";
            this.lb值日生.Size = new System.Drawing.Size(0, 36);
            this.lb值日生.TabIndex = 7;
            // 
            // btn學員資料
            // 
            this.btn學員資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn學員資料.Location = new System.Drawing.Point(699, 0);
            this.btn學員資料.Name = "btn學員資料";
            this.btn學員資料.Size = new System.Drawing.Size(212, 42);
            this.btn學員資料.TabIndex = 8;
            this.btn學員資料.Text = "學員資料維護";
            this.btn學員資料.UseVisualStyleBackColor = true;
            this.btn學員資料.Click += new System.EventHandler(this.btn學員資料_Click);
            // 
            // btn廠商資料
            // 
            this.btn廠商資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn廠商資料.Location = new System.Drawing.Point(924, 0);
            this.btn廠商資料.Name = "btn廠商資料";
            this.btn廠商資料.Size = new System.Drawing.Size(212, 42);
            this.btn廠商資料.TabIndex = 9;
            this.btn廠商資料.Text = "廠商資料維護";
            this.btn廠商資料.UseVisualStyleBackColor = true;
            this.btn廠商資料.Click += new System.EventHandler(this.btn廠商資料_Click);
            // 
            // btn菜單
            // 
            this.btn菜單.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn菜單.Location = new System.Drawing.Point(12, 411);
            this.btn菜單.Name = "btn菜單";
            this.btn菜單.Size = new System.Drawing.Size(212, 80);
            this.btn菜單.TabIndex = 10;
            this.btn菜單.Text = "菜單一覽";
            this.btn菜單.UseVisualStyleBackColor = true;
            this.btn菜單.Click += new System.EventHandler(this.btn菜單_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(878, 248);
            this.dataGridView1.TabIndex = 13;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "order_detail";
            this.orderdetailBindingSource.DataSource = this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet;
            // 
            // _D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet
            // 
            this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet.DataSetName = "_D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet";
            this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(800, 50);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(316, 160);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "本日值日生";
            // 
            // btn菜單資料維護
            // 
            this.btn菜單資料維護.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn菜單資料維護.Location = new System.Drawing.Point(476, 0);
            this.btn菜單資料維護.Name = "btn菜單資料維護";
            this.btn菜單資料維護.Size = new System.Drawing.Size(212, 42);
            this.btn菜單資料維護.TabIndex = 15;
            this.btn菜單資料維護.Text = "菜單資料維護";
            this.btn菜單資料維護.UseVisualStyleBackColor = true;
            this.btn菜單資料維護.Click += new System.EventHandler(this.btn菜單資料維護_Click);
            // 
            // order_detailTableAdapter
            // 
            this.order_detailTableAdapter.ClearBeforeFill = true;
            // 
            // lbl時間
            // 
            this.lbl時間.AutoSize = true;
            this.lbl時間.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl時間.Location = new System.Drawing.Point(782, 214);
            this.lbl時間.Name = "lbl時間";
            this.lbl時間.Size = new System.Drawing.Size(127, 36);
            this.lbl時間.TabIndex = 16;
            this.lbl時間.Text = "今日時間";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl份數總價
            // 
            this.lbl份數總價.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl份數總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl份數總價.Location = new System.Drawing.Point(483, 262);
            this.lbl份數總價.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl份數總價.Name = "lbl份數總價";
            this.lbl份數總價.Size = new System.Drawing.Size(194, 44);
            this.lbl份數總價.TabIndex = 15;
            this.lbl份數總價.Text = "0";
            this.lbl份數總價.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(477, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "份數總價";
            // 
            // lbl時間2
            // 
            this.lbl時間2.AutoSize = true;
            this.lbl時間2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl時間2.Location = new System.Drawing.Point(794, 272);
            this.lbl時間2.Name = "lbl時間2";
            this.lbl時間2.Size = new System.Drawing.Size(0, 36);
            this.lbl時間2.TabIndex = 17;
            // 
            // III便當訂購系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 600);
            this.Controls.Add(this.lbl時間2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl份數總價);
            this.Controls.Add(this.lbl時間);
            this.Controls.Add(this.btn菜單資料維護);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn菜單);
            this.Controls.Add(this.btn廠商資料);
            this.Controls.Add(this.btn學員資料);
            this.Controls.Add(this.lb值日生);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "III便當訂購系統";
            this.Text = "III便當訂購系統";
            this.Load += new System.EventHandler(this.III便當訂購系統_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb數量;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.ComboBox cb品名;
        private System.Windows.Forms.ComboBox cb店家;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb姓名;
        private System.Windows.Forms.ComboBox cb期別;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb值日生;
        private System.Windows.Forms.Button btn學員資料;
        private System.Windows.Forms.Button btn廠商資料;
        private System.Windows.Forms.Button btn菜單;
        private System.Windows.Forms.Button btn加入訂單;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn菜單資料維護;
        private System.Windows.Forms.Label lbl單價;
        private _D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet _D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSet;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private _D__資策會用_C_用_III_便當訂購系統_III_便當訂購系統_IIIFOODSYSTEM_MDFDataSetTableAdapters.order_detailTableAdapter order_detailTableAdapter;
        private System.Windows.Forms.Button btn訂單刪除;
        private System.Windows.Forms.Label lbl時間;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl份數總價;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl時間2;
    }
}

