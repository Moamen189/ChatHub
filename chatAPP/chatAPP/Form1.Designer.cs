
namespace chatAPP
{
    partial class Form1
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
            this.txt_mess = new System.Windows.Forms.TextBox();
            this.txt_group = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_sendmessage = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_sendtogroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_mess = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_mess
            // 
            this.txt_mess.Location = new System.Drawing.Point(67, 66);
            this.txt_mess.Name = "txt_mess";
            this.txt_mess.Size = new System.Drawing.Size(100, 20);
            this.txt_mess.TabIndex = 0;
            // 
            // txt_group
            // 
            this.txt_group.Location = new System.Drawing.Point(67, 91);
            this.txt_group.Name = "txt_group";
            this.txt_group.Size = new System.Drawing.Size(100, 20);
            this.txt_group.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(248, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(256, 20);
            this.txt_name.TabIndex = 2;
            // 
            // btn_sendmessage
            // 
            this.btn_sendmessage.Location = new System.Drawing.Point(210, 64);
            this.btn_sendmessage.Name = "btn_sendmessage";
            this.btn_sendmessage.Size = new System.Drawing.Size(75, 23);
            this.btn_sendmessage.TabIndex = 3;
            this.btn_sendmessage.Text = "send";
            this.btn_sendmessage.UseVisualStyleBackColor = true;
            this.btn_sendmessage.Click += new System.EventHandler(this.btn_sendmessage_Click);
            // 
            // btn_join
            // 
            this.btn_join.Location = new System.Drawing.Point(210, 93);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(75, 23);
            this.btn_join.TabIndex = 4;
            this.btn_join.Text = "join";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_sendtogroup
            // 
            this.btn_sendtogroup.Location = new System.Drawing.Point(173, 131);
            this.btn_sendtogroup.Name = "btn_sendtogroup";
            this.btn_sendtogroup.Size = new System.Drawing.Size(75, 23);
            this.btn_sendtogroup.TabIndex = 5;
            this.btn_sendtogroup.Text = "send to group";
            this.btn_sendtogroup.UseVisualStyleBackColor = true;
            this.btn_sendtogroup.Click += new System.EventHandler(this.btn_sendtogroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "group name";
            // 
            // lb_mess
            // 
            this.lb_mess.FormattingEnabled = true;
            this.lb_mess.Location = new System.Drawing.Point(32, 168);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(565, 212);
            this.lb_mess.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_mess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sendtogroup);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_sendmessage);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_group);
            this.Controls.Add(this.txt_mess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mess;
        private System.Windows.Forms.TextBox txt_group;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_sendmessage;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.Button btn_sendtogroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_mess;
        private System.Windows.Forms.Label label3;
    }
}

