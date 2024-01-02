namespace OtelKayit.WebFormsUI
{
    partial class Form2
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
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerSurname = new System.Windows.Forms.Label();
            this.lblCustomerTc = new System.Windows.Forms.Label();
            this.lblGiristarihi = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.tboxCustomerName = new System.Windows.Forms.TextBox();
            this.tboxCustomerSurname = new System.Windows.Forms.TextBox();
            this.tboxCustomerTc = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblMüşteriAdıAra = new System.Windows.Forms.Label();
            this.dateTimeGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxOdaNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOdaNo3 = new System.Windows.Forms.Button();
            this.btnOdaNo2 = new System.Windows.Forms.Button();
            this.btnOdaNo4 = new System.Windows.Forms.Button();
            this.btnOdaNo5 = new System.Windows.Forms.Button();
            this.btnOdaNo6 = new System.Windows.Forms.Button();
            this.btnOdaNo7 = new System.Windows.Forms.Button();
            this.btnOdaNo8 = new System.Windows.Forms.Button();
            this.btnOdaNo9 = new System.Windows.Forms.Button();
            this.btnOdaNo10 = new System.Windows.Forms.Button();
            this.lblGun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.BackgroundColor = System.Drawing.Color.Teal;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(12, 346);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.Size = new System.Drawing.Size(582, 237);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellClick);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerName.Location = new System.Drawing.Point(600, 346);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 15);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "MÜŞTERİ ADI :";
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.AutoSize = true;
            this.lblCustomerSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSurname.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerSurname.Location = new System.Drawing.Point(600, 379);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(130, 15);
            this.lblCustomerSurname.TabIndex = 2;
            this.lblCustomerSurname.Text = "MÜŞTERİ SOYADI :";
            // 
            // lblCustomerTc
            // 
            this.lblCustomerTc.AutoSize = true;
            this.lblCustomerTc.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerTc.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerTc.Location = new System.Drawing.Point(603, 412);
            this.lblCustomerTc.Name = "lblCustomerTc";
            this.lblCustomerTc.Size = new System.Drawing.Size(98, 15);
            this.lblCustomerTc.TabIndex = 3;
            this.lblCustomerTc.Text = "MÜŞTERİ TC :";
            // 
            // lblGiristarihi
            // 
            this.lblGiristarihi.AutoSize = true;
            this.lblGiristarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblGiristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiristarihi.ForeColor = System.Drawing.Color.Red;
            this.lblGiristarihi.Location = new System.Drawing.Point(598, 522);
            this.lblGiristarihi.Name = "lblGiristarihi";
            this.lblGiristarihi.Size = new System.Drawing.Size(100, 15);
            this.lblGiristarihi.TabIndex = 4;
            this.lblGiristarihi.Text = "GİRİŞ TARİHİ :";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.Red;
            this.lblCikisTarihi.Location = new System.Drawing.Point(600, 555);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(98, 15);
            this.lblCikisTarihi.TabIndex = 5;
            this.lblCikisTarihi.Text = "ÇIKIŞ TARİHİ :";
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tboxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxCustomerName.Location = new System.Drawing.Point(704, 346);
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.Size = new System.Drawing.Size(110, 20);
            this.tboxCustomerName.TabIndex = 6;
            // 
            // tboxCustomerSurname
            // 
            this.tboxCustomerSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tboxCustomerSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxCustomerSurname.Location = new System.Drawing.Point(736, 379);
            this.tboxCustomerSurname.Name = "tboxCustomerSurname";
            this.tboxCustomerSurname.Size = new System.Drawing.Size(110, 20);
            this.tboxCustomerSurname.TabIndex = 7;
            // 
            // tboxCustomerTc
            // 
            this.tboxCustomerTc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tboxCustomerTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxCustomerTc.Location = new System.Drawing.Point(707, 412);
            this.tboxCustomerTc.Name = "tboxCustomerTc";
            this.tboxCustomerTc.Size = new System.Drawing.Size(117, 20);
            this.tboxCustomerTc.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkle.Location = new System.Drawing.Point(282, 292);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(122, 45);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Müşteri Kayıt";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbxCustomerSearch);
            this.groupBox1.Controls.Add(this.lblMüşteriAdıAra);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ ARA";
            // 
            // tbxCustomerSearch
            // 
            this.tbxCustomerSearch.BackColor = System.Drawing.Color.Gray;
            this.tbxCustomerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCustomerSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbxCustomerSearch.Location = new System.Drawing.Point(78, 20);
            this.tbxCustomerSearch.Name = "tbxCustomerSearch";
            this.tbxCustomerSearch.Size = new System.Drawing.Size(168, 20);
            this.tbxCustomerSearch.TabIndex = 1;
            this.tbxCustomerSearch.TextChanged += new System.EventHandler(this.tbxCustomerSearch_TextChanged);
            // 
            // lblMüşteriAdıAra
            // 
            this.lblMüşteriAdıAra.AutoSize = true;
            this.lblMüşteriAdıAra.Location = new System.Drawing.Point(6, 24);
            this.lblMüşteriAdıAra.Name = "lblMüşteriAdıAra";
            this.lblMüşteriAdıAra.Size = new System.Drawing.Size(65, 13);
            this.lblMüşteriAdıAra.TabIndex = 0;
            this.lblMüşteriAdıAra.Text = "Müşteri Adı :";
            // 
            // dateTimeGirisTarihi
            // 
            this.dateTimeGirisTarihi.Location = new System.Drawing.Point(707, 518);
            this.dateTimeGirisTarihi.Name = "dateTimeGirisTarihi";
            this.dateTimeGirisTarihi.Size = new System.Drawing.Size(170, 20);
            this.dateTimeGirisTarihi.TabIndex = 13;
            // 
            // dateTimeCikisTarihi
            // 
            this.dateTimeCikisTarihi.Location = new System.Drawing.Point(707, 550);
            this.dateTimeCikisTarihi.Name = "dateTimeCikisTarihi";
            this.dateTimeCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCikisTarihi.TabIndex = 14;
            this.dateTimeCikisTarihi.ValueChanged += new System.EventHandler(this.dateTimeCikisTarihi_ValueChanged);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomerUpdate.Location = new System.Drawing.Point(410, 292);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(122, 45);
            this.btnCustomerUpdate.TabIndex = 15;
            this.btnCustomerUpdate.Text = "Müşteri Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCustomerDelete.Location = new System.Drawing.Point(538, 292);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(122, 45);
            this.btnCustomerDelete.TabIndex = 16;
            this.btnCustomerDelete.Text = "Müşteri Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(603, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "ÜCRET :";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(678, 482);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(100, 20);
            this.tboxPrice.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(605, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "OdaNo :";
            // 
            // tboxOdaNo
            // 
            this.tboxOdaNo.Location = new System.Drawing.Point(678, 449);
            this.tboxOdaNo.Name = "tboxOdaNo";
            this.tboxOdaNo.Size = new System.Drawing.Size(100, 20);
            this.tboxOdaNo.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOdaNo10);
            this.groupBox2.Controls.Add(this.btnOdaNo9);
            this.groupBox2.Controls.Add(this.btnOdaNo8);
            this.groupBox2.Controls.Add(this.btnOdaNo7);
            this.groupBox2.Controls.Add(this.btnOdaNo6);
            this.groupBox2.Controls.Add(this.btnOdaNo5);
            this.groupBox2.Controls.Add(this.btnOdaNo4);
            this.groupBox2.Controls.Add(this.btnOdaNo2);
            this.groupBox2.Controls.Add(this.btnOdaNo3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(926, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 263);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ODALAR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "101";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdaNo3
            // 
            this.btnOdaNo3.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo3.Location = new System.Drawing.Point(16, 120);
            this.btnOdaNo3.Name = "btnOdaNo3";
            this.btnOdaNo3.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo3.TabIndex = 1;
            this.btnOdaNo3.Text = "103";
            this.btnOdaNo3.UseVisualStyleBackColor = true;
            this.btnOdaNo3.Click += new System.EventHandler(this.btnOdaNo3_Click);
            // 
            // btnOdaNo2
            // 
            this.btnOdaNo2.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo2.Location = new System.Drawing.Point(16, 74);
            this.btnOdaNo2.Name = "btnOdaNo2";
            this.btnOdaNo2.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo2.TabIndex = 2;
            this.btnOdaNo2.Text = "102";
            this.btnOdaNo2.UseVisualStyleBackColor = true;
            this.btnOdaNo2.Click += new System.EventHandler(this.btnOdaNo2_Click);
            // 
            // btnOdaNo4
            // 
            this.btnOdaNo4.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo4.Location = new System.Drawing.Point(16, 165);
            this.btnOdaNo4.Name = "btnOdaNo4";
            this.btnOdaNo4.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo4.TabIndex = 3;
            this.btnOdaNo4.Text = "104";
            this.btnOdaNo4.UseVisualStyleBackColor = true;
            this.btnOdaNo4.Click += new System.EventHandler(this.btnOdaNo4_Click);
            // 
            // btnOdaNo5
            // 
            this.btnOdaNo5.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo5.Location = new System.Drawing.Point(16, 210);
            this.btnOdaNo5.Name = "btnOdaNo5";
            this.btnOdaNo5.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo5.TabIndex = 4;
            this.btnOdaNo5.Text = "105";
            this.btnOdaNo5.UseVisualStyleBackColor = true;
            this.btnOdaNo5.Click += new System.EventHandler(this.btnOdaNo5_Click);
            // 
            // btnOdaNo6
            // 
            this.btnOdaNo6.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo6.Location = new System.Drawing.Point(101, 28);
            this.btnOdaNo6.Name = "btnOdaNo6";
            this.btnOdaNo6.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo6.TabIndex = 5;
            this.btnOdaNo6.Text = "106";
            this.btnOdaNo6.UseVisualStyleBackColor = true;
            this.btnOdaNo6.Click += new System.EventHandler(this.btnOdaNo6_Click);
            // 
            // btnOdaNo7
            // 
            this.btnOdaNo7.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo7.Location = new System.Drawing.Point(101, 74);
            this.btnOdaNo7.Name = "btnOdaNo7";
            this.btnOdaNo7.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo7.TabIndex = 6;
            this.btnOdaNo7.Text = "107";
            this.btnOdaNo7.UseVisualStyleBackColor = true;
            this.btnOdaNo7.Click += new System.EventHandler(this.btnOdaNo7_Click);
            // 
            // btnOdaNo8
            // 
            this.btnOdaNo8.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo8.Location = new System.Drawing.Point(101, 119);
            this.btnOdaNo8.Name = "btnOdaNo8";
            this.btnOdaNo8.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo8.TabIndex = 7;
            this.btnOdaNo8.Text = "108";
            this.btnOdaNo8.UseVisualStyleBackColor = true;
            this.btnOdaNo8.Click += new System.EventHandler(this.btnOdaNo8_Click);
            // 
            // btnOdaNo9
            // 
            this.btnOdaNo9.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo9.Location = new System.Drawing.Point(101, 164);
            this.btnOdaNo9.Name = "btnOdaNo9";
            this.btnOdaNo9.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo9.TabIndex = 8;
            this.btnOdaNo9.Text = "109";
            this.btnOdaNo9.UseVisualStyleBackColor = true;
            this.btnOdaNo9.Click += new System.EventHandler(this.btnOdaNo9_Click);
            // 
            // btnOdaNo10
            // 
            this.btnOdaNo10.ForeColor = System.Drawing.Color.Black;
            this.btnOdaNo10.Location = new System.Drawing.Point(101, 210);
            this.btnOdaNo10.Name = "btnOdaNo10";
            this.btnOdaNo10.Size = new System.Drawing.Size(79, 40);
            this.btnOdaNo10.TabIndex = 9;
            this.btnOdaNo10.Text = "110";
            this.btnOdaNo10.UseVisualStyleBackColor = true;
            this.btnOdaNo10.Click += new System.EventHandler(this.btnOdaNo10_Click);
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.BackColor = System.Drawing.Color.Transparent;
            this.lblGun.ForeColor = System.Drawing.Color.White;
            this.lblGun.Location = new System.Drawing.Point(893, 522);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(27, 13);
            this.lblGun.TabIndex = 22;
            this.lblGun.Text = "Gün";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OtelKayit.WebFormsUI.Properties.Resources.tiktak1;
            this.ClientSize = new System.Drawing.Size(1111, 597);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tboxOdaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.dateTimeCikisTarihi);
            this.Controls.Add(this.dateTimeGirisTarihi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tboxCustomerTc);
            this.Controls.Add(this.tboxCustomerSurname);
            this.Controls.Add(this.tboxCustomerName);
            this.Controls.Add(this.lblCikisTarihi);
            this.Controls.Add(this.lblGiristarihi);
            this.Controls.Add(this.lblCustomerTc);
            this.Controls.Add(this.lblCustomerSurname);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dgwCustomers);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerSurname;
        private System.Windows.Forms.Label lblCustomerTc;
        private System.Windows.Forms.Label lblGiristarihi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.TextBox tboxCustomerName;
        private System.Windows.Forms.TextBox tboxCustomerSurname;
        private System.Windows.Forms.TextBox tboxCustomerTc;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxCustomerSearch;
        private System.Windows.Forms.Label lblMüşteriAdıAra;
        private System.Windows.Forms.DateTimePicker dateTimeGirisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimeCikisTarihi;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxOdaNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdaNo4;
        private System.Windows.Forms.Button btnOdaNo2;
        private System.Windows.Forms.Button btnOdaNo3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOdaNo10;
        private System.Windows.Forms.Button btnOdaNo9;
        private System.Windows.Forms.Button btnOdaNo8;
        private System.Windows.Forms.Button btnOdaNo7;
        private System.Windows.Forms.Button btnOdaNo6;
        private System.Windows.Forms.Button btnOdaNo5;
        private System.Windows.Forms.Label lblGun;
    }
}