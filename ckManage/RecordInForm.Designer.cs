namespace ckManage
{
    partial class RecordInForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_comfirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_goods = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_buy_record = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_buy_record);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combox_goods);
            this.groupBox1.Controls.Add(this.btn_comfirm);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_weight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 233);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_comfirm
            // 
            this.btn_comfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_comfirm.Location = new System.Drawing.Point(181, 170);
            this.btn_comfirm.Name = "btn_comfirm";
            this.btn_comfirm.Size = new System.Drawing.Size(75, 36);
            this.btn_comfirm.TabIndex = 9;
            this.btn_comfirm.Text = "确认";
            this.btn_comfirm.UseVisualStyleBackColor = true;
            this.btn_comfirm.Click += new System.EventHandler(this.btn_comfirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(72, 170);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "重量/数量：";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(118, 75);
            this.txt_weight.MaxLength = 10;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(174, 21);
            this.txt_weight.TabIndex = 7;
            this.txt_weight.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原材料品名：";
            // 
            // combox_goods
            // 
            this.combox_goods.FormattingEnabled = true;
            this.combox_goods.Location = new System.Drawing.Point(118, 36);
            this.combox_goods.Name = "combox_goods";
            this.combox_goods.Size = new System.Drawing.Size(174, 20);
            this.combox_goods.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "入库时间：";
            // 
            // dt_buy_record
            // 
            this.dt_buy_record.Location = new System.Drawing.Point(118, 122);
            this.dt_buy_record.Name = "dt_buy_record";
            this.dt_buy_record.Size = new System.Drawing.Size(174, 21);
            this.dt_buy_record.TabIndex = 12;
            // 
            // RecordInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 260);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(354, 299);
            this.MinimumSize = new System.Drawing.Size(354, 299);
            this.Name = "RecordInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增入库";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combox_goods;
        private System.Windows.Forms.Button btn_comfirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_buy_record;
    }
}