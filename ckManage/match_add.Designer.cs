﻿namespace ckManage
{
    partial class match_add
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
            this.txt_match_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_match_add_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入配比代号：";
            // 
            // txt_match_name
            // 
            this.txt_match_name.Location = new System.Drawing.Point(125, 33);
            this.txt_match_name.Name = "txt_match_name";
            this.txt_match_name.Size = new System.Drawing.Size(172, 21);
            this.txt_match_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "注意：\r\n\r\n1、所添加的配比为表格中的数据；\r\n\r\n2、配比名称不能和之前的重复。\r\n";
            // 
            // btn_match_add_confirm
            // 
            this.btn_match_add_confirm.Location = new System.Drawing.Point(324, 33);
            this.btn_match_add_confirm.Name = "btn_match_add_confirm";
            this.btn_match_add_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_match_add_confirm.TabIndex = 3;
            this.btn_match_add_confirm.Text = "确定";
            this.btn_match_add_confirm.UseVisualStyleBackColor = true;
            this.btn_match_add_confirm.Click += new System.EventHandler(this.btn_match_add_confirm_Click);
            // 
            // match_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 151);
            this.Controls.Add(this.btn_match_add_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_match_name);
            this.Controls.Add(this.label1);
            this.Name = "match_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加配比";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_match_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_match_add_confirm;
    }
}