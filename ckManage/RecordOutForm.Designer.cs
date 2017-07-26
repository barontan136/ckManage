namespace ckManage
{
    partial class RecordOutForm
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
            this.dt_sold = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_match = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_comfirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dt_sold
            // 
            this.dt_sold.Location = new System.Drawing.Point(129, 131);
            this.dt_sold.Name = "dt_sold";
            this.dt_sold.Size = new System.Drawing.Size(174, 21);
            this.dt_sold.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "出库时间：";
            // 
            // combox_match
            // 
            this.combox_match.FormattingEnabled = true;
            this.combox_match.Location = new System.Drawing.Point(129, 50);
            this.combox_match.Name = "combox_match";
            this.combox_match.Size = new System.Drawing.Size(174, 20);
            this.combox_match.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "出库数量(方)：";
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(129, 89);
            this.txt_weight.MaxLength = 10;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(174, 21);
            this.txt_weight.TabIndex = 15;
            this.txt_weight.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "选择配比编号：";
            // 
            // btn_comfirm
            // 
            this.btn_comfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_comfirm.Location = new System.Drawing.Point(181, 183);
            this.btn_comfirm.Name = "btn_comfirm";
            this.btn_comfirm.Size = new System.Drawing.Size(75, 36);
            this.btn_comfirm.TabIndex = 20;
            this.btn_comfirm.Text = "确认";
            this.btn_comfirm.UseVisualStyleBackColor = true;
            this.btn_comfirm.Click += new System.EventHandler(this.btn_comfirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(72, 183);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // RecordOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 260);
            this.Controls.Add(this.btn_comfirm);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dt_sold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combox_match);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(354, 299);
            this.MinimumSize = new System.Drawing.Size(354, 299);
            this.Name = "RecordOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出库操作";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_sold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combox_match;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_comfirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}