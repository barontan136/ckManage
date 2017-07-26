namespace ckManage
{
    partial class goods_add
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_goods_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_goods_add_ok = new System.Windows.Forms.Button();
            this.btn_goods_add_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_min_weight = new System.Windows.Forms.TextBox();
            this.combox_goods_unit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_goods_company = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_status = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原材料品名：";
            // 
            // txt_goods_name
            // 
            this.txt_goods_name.Location = new System.Drawing.Point(118, 24);
            this.txt_goods_name.Name = "txt_goods_name";
            this.txt_goods_name.Size = new System.Drawing.Size(174, 21);
            this.txt_goods_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combox_status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_goods_add_ok);
            this.groupBox1.Controls.Add(this.btn_goods_add_cancel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_min_weight);
            this.groupBox1.Controls.Add(this.combox_goods_unit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_goods_company);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_goods_name);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_goods_add_ok
            // 
            this.btn_goods_add_ok.Location = new System.Drawing.Point(178, 233);
            this.btn_goods_add_ok.Name = "btn_goods_add_ok";
            this.btn_goods_add_ok.Size = new System.Drawing.Size(75, 36);
            this.btn_goods_add_ok.TabIndex = 9;
            this.btn_goods_add_ok.Text = "确认";
            this.btn_goods_add_ok.UseVisualStyleBackColor = true;
            this.btn_goods_add_ok.Click += new System.EventHandler(this.btn_goods_add_ok_Click);
            // 
            // btn_goods_add_cancel
            // 
            this.btn_goods_add_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_goods_add_cancel.Location = new System.Drawing.Point(80, 233);
            this.btn_goods_add_cancel.Name = "btn_goods_add_cancel";
            this.btn_goods_add_cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_goods_add_cancel.TabIndex = 8;
            this.btn_goods_add_cancel.Text = "取消";
            this.btn_goods_add_cancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "报警数量：";
            // 
            // txt_min_weight
            // 
            this.txt_min_weight.Location = new System.Drawing.Point(118, 150);
            this.txt_min_weight.MaxLength = 10;
            this.txt_min_weight.Name = "txt_min_weight";
            this.txt_min_weight.Size = new System.Drawing.Size(174, 21);
            this.txt_min_weight.TabIndex = 7;
            // 
            // combox_goods_unit
            // 
            this.combox_goods_unit.FormattingEnabled = true;
            this.combox_goods_unit.Location = new System.Drawing.Point(118, 106);
            this.combox_goods_unit.Name = "combox_goods_unit";
            this.combox_goods_unit.Size = new System.Drawing.Size(174, 20);
            this.combox_goods_unit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "材料单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "供应商：";
            // 
            // txt_goods_company
            // 
            this.txt_goods_company.Location = new System.Drawing.Point(118, 63);
            this.txt_goods_company.Name = "txt_goods_company";
            this.txt_goods_company.Size = new System.Drawing.Size(174, 21);
            this.txt_goods_company.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "状态：";
            // 
            // combox_status
            // 
            this.combox_status.AutoCompleteCustomSource.AddRange(new string[] {
            "正常#0",
            "废弃#1",
            "删除#2"});
            this.combox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_status.FormattingEnabled = true;
            this.combox_status.Items.AddRange(new object[] {
            "正常,0",
            "废弃,1",
            "删除,2"});
            this.combox_status.Location = new System.Drawing.Point(118, 192);
            this.combox_status.Name = "combox_status";
            this.combox_status.Size = new System.Drawing.Size(174, 20);
            this.combox_status.TabIndex = 11;
            // 
            // goods_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 304);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(364, 343);
            this.MinimumSize = new System.Drawing.Size(364, 343);
            this.Name = "goods_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增原材料";
            this.Load += new System.EventHandler(this.goods_add_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_goods_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_goods_company;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_min_weight;
        private System.Windows.Forms.ComboBox combox_goods_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_goods_add_ok;
        private System.Windows.Forms.Button btn_goods_add_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combox_status;
    }
}