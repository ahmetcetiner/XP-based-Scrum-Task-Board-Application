namespace XP_based_Scrum_Task_Board_Application
{
    partial class Form_EmployeesDetails
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
            this.txt_EmployeesName = new System.Windows.Forms.TextBox();
            this.lbl_EmployeesName = new System.Windows.Forms.Label();
            this.txt_EmployeesLastName = new System.Windows.Forms.TextBox();
            this.lbl_EmployeesLastName = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_EmployeesName
            // 
            this.txt_EmployeesName.Location = new System.Drawing.Point(201, 39);
            this.txt_EmployeesName.Name = "txt_EmployeesName";
            this.txt_EmployeesName.Size = new System.Drawing.Size(176, 20);
            this.txt_EmployeesName.TabIndex = 3;
            // 
            // lbl_EmployeesName
            // 
            this.lbl_EmployeesName.AutoSize = true;
            this.lbl_EmployeesName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EmployeesName.Location = new System.Drawing.Point(28, 39);
            this.lbl_EmployeesName.Name = "lbl_EmployeesName";
            this.lbl_EmployeesName.Size = new System.Drawing.Size(120, 17);
            this.lbl_EmployeesName.TabIndex = 2;
            this.lbl_EmployeesName.Text = "Employees Name :";
            // 
            // txt_EmployeesLastName
            // 
            this.txt_EmployeesLastName.Location = new System.Drawing.Point(201, 76);
            this.txt_EmployeesLastName.Name = "txt_EmployeesLastName";
            this.txt_EmployeesLastName.Size = new System.Drawing.Size(176, 20);
            this.txt_EmployeesLastName.TabIndex = 5;
            // 
            // lbl_EmployeesLastName
            // 
            this.lbl_EmployeesLastName.AutoSize = true;
            this.lbl_EmployeesLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EmployeesLastName.Location = new System.Drawing.Point(28, 76);
            this.lbl_EmployeesLastName.Name = "lbl_EmployeesLastName";
            this.lbl_EmployeesLastName.Size = new System.Drawing.Size(148, 17);
            this.lbl_EmployeesLastName.TabIndex = 4;
            this.lbl_EmployeesLastName.Text = "Employees Last Name :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(289, 185);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 28);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(200, 185);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(83, 28);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "Add";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(111, 185);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(83, 28);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(22, 185);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(83, 28);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // Form_EmployeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 225);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_EmployeesLastName);
            this.Controls.Add(this.lbl_EmployeesLastName);
            this.Controls.Add(this.txt_EmployeesName);
            this.Controls.Add(this.lbl_EmployeesName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EmployeesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_EmployeesDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_EmployeesName;
        private System.Windows.Forms.Label lbl_EmployeesName;
        private System.Windows.Forms.TextBox txt_EmployeesLastName;
        private System.Windows.Forms.Label lbl_EmployeesLastName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
    }
}