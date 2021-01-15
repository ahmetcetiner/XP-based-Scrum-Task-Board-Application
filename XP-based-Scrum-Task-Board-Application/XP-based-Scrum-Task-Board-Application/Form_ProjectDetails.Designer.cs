namespace XP_based_Scrum_Task_Board_Application
{
    partial class Form_ProjectDetails
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
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.lbox_Employees = new System.Windows.Forms.ListBox();
            this.lbox_SelectedEmployees = new System.Windows.Forms.ListBox();
            this.lbl_Employees = new System.Windows.Forms.Label();
            this.lbl_SelectedEmployees = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProjectName.Location = new System.Drawing.Point(19, 32);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(70, 17);
            this.lbl_ProjectName.TabIndex = 0;
            this.lbl_ProjectName.Text = "Proje Adı :";
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(117, 32);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(127, 20);
            this.txt_ProjectName.TabIndex = 1;
            // 
            // lbox_Employees
            // 
            this.lbox_Employees.FormattingEnabled = true;
            this.lbox_Employees.Location = new System.Drawing.Point(12, 113);
            this.lbox_Employees.Name = "lbox_Employees";
            this.lbox_Employees.Size = new System.Drawing.Size(150, 225);
            this.lbox_Employees.TabIndex = 2;
            // 
            // lbox_SelectedEmployees
            // 
            this.lbox_SelectedEmployees.FormattingEnabled = true;
            this.lbox_SelectedEmployees.Location = new System.Drawing.Point(238, 113);
            this.lbox_SelectedEmployees.Name = "lbox_SelectedEmployees";
            this.lbox_SelectedEmployees.Size = new System.Drawing.Size(150, 225);
            this.lbox_SelectedEmployees.TabIndex = 3;
            // 
            // lbl_Employees
            // 
            this.lbl_Employees.AutoSize = true;
            this.lbl_Employees.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Employees.Location = new System.Drawing.Point(9, 93);
            this.lbl_Employees.Name = "lbl_Employees";
            this.lbl_Employees.Size = new System.Drawing.Size(80, 17);
            this.lbl_Employees.TabIndex = 4;
            this.lbl_Employees.Text = "EMPLOYEES";
            // 
            // lbl_SelectedEmployees
            // 
            this.lbl_SelectedEmployees.AutoSize = true;
            this.lbl_SelectedEmployees.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SelectedEmployees.Location = new System.Drawing.Point(235, 93);
            this.lbl_SelectedEmployees.Name = "lbl_SelectedEmployees";
            this.lbl_SelectedEmployees.Size = new System.Drawing.Size(142, 17);
            this.lbl_SelectedEmployees.TabIndex = 5;
            this.lbl_SelectedEmployees.Text = "SELECTED EMPLOYEES";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(305, 360);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(83, 28);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "Okey";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_right_1;
            this.pictureBox1.Location = new System.Drawing.Point(184, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_SelectedEmployees);
            this.Controls.Add(this.lbl_Employees);
            this.Controls.Add(this.lbox_SelectedEmployees);
            this.Controls.Add(this.lbox_Employees);
            this.Controls.Add(this.txt_ProjectName);
            this.Controls.Add(this.lbl_ProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ProjectDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProjectDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.ListBox lbox_Employees;
        private System.Windows.Forms.ListBox lbox_SelectedEmployees;
        private System.Windows.Forms.Label lbl_Employees;
        private System.Windows.Forms.Label lbl_SelectedEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Ok;
    }
}