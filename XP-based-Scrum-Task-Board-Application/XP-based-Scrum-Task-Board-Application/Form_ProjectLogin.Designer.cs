namespace XP_based_Scrum_Task_Board_Application
{
    partial class Form_ProjectLogin
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
            this.Panel_Project = new System.Windows.Forms.Panel();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.Panel_Baslik = new System.Windows.Forms.Panel();
            this.btn_EmployeesCardAdd = new System.Windows.Forms.PictureBox();
            this.btn_ProjectCardAdd = new System.Windows.Forms.PictureBox();
            this.lbl_EmployeesBaslik = new System.Windows.Forms.Label();
            this.lbl_ProjectBaslik = new System.Windows.Forms.Label();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Panel_Employees = new System.Windows.Forms.Panel();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.Panel_Baslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EmployeesCardAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ProjectCardAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Project
            // 
            this.Panel_Project.AutoScroll = true;
            this.Panel_Project.Location = new System.Drawing.Point(0, 90);
            this.Panel_Project.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Project.Name = "Panel_Project";
            this.Panel_Project.Size = new System.Drawing.Size(350, 600);
            this.Panel_Project.TabIndex = 0;
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Panel_Top.Controls.Add(this.btn_Close);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(800, 40);
            this.Panel_Top.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Close.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_shutdown_2;
            this.btn_Close.ImageLocation = "";
            this.btn_Close.Location = new System.Drawing.Point(762, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Close.TabIndex = 1;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // Panel_Baslik
            // 
            this.Panel_Baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(193)))), ((int)(((byte)(172)))));
            this.Panel_Baslik.Controls.Add(this.btn_EmployeesCardAdd);
            this.Panel_Baslik.Controls.Add(this.btn_ProjectCardAdd);
            this.Panel_Baslik.Controls.Add(this.lbl_EmployeesBaslik);
            this.Panel_Baslik.Controls.Add(this.lbl_ProjectBaslik);
            this.Panel_Baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Baslik.Location = new System.Drawing.Point(0, 40);
            this.Panel_Baslik.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Baslik.Name = "Panel_Baslik";
            this.Panel_Baslik.Size = new System.Drawing.Size(800, 50);
            this.Panel_Baslik.TabIndex = 2;
            // 
            // btn_EmployeesCardAdd
            // 
            this.btn_EmployeesCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EmployeesCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_EmployeesCardAdd.ImageLocation = "";
            this.btn_EmployeesCardAdd.Location = new System.Drawing.Point(777, 4);
            this.btn_EmployeesCardAdd.Name = "btn_EmployeesCardAdd";
            this.btn_EmployeesCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_EmployeesCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_EmployeesCardAdd.TabIndex = 4;
            this.btn_EmployeesCardAdd.TabStop = false;
            this.btn_EmployeesCardAdd.Click += new System.EventHandler(this.btn_EmployeesCardAdd_Click);
            // 
            // btn_ProjectCardAdd
            // 
            this.btn_ProjectCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ProjectCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_ProjectCardAdd.ImageLocation = "";
            this.btn_ProjectCardAdd.Location = new System.Drawing.Point(330, 3);
            this.btn_ProjectCardAdd.Name = "btn_ProjectCardAdd";
            this.btn_ProjectCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_ProjectCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_ProjectCardAdd.TabIndex = 3;
            this.btn_ProjectCardAdd.TabStop = false;
            this.btn_ProjectCardAdd.Click += new System.EventHandler(this.btn_ProjectCardAdd_Click);
            // 
            // lbl_EmployeesBaslik
            // 
            this.lbl_EmployeesBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EmployeesBaslik.Location = new System.Drawing.Point(500, 0);
            this.lbl_EmployeesBaslik.Name = "lbl_EmployeesBaslik";
            this.lbl_EmployeesBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_EmployeesBaslik.TabIndex = 2;
            this.lbl_EmployeesBaslik.Text = "EMPLOYEES";
            this.lbl_EmployeesBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ProjectBaslik
            // 
            this.lbl_ProjectBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ProjectBaslik.Location = new System.Drawing.Point(50, 0);
            this.lbl_ProjectBaslik.Name = "lbl_ProjectBaslik";
            this.lbl_ProjectBaslik.Size = new System.Drawing.Size(250, 50);
            this.lbl_ProjectBaslik.TabIndex = 1;
            this.lbl_ProjectBaslik.Text = "PROJECTS";
            this.lbl_ProjectBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 690);
            this.Panel_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(800, 10);
            this.Panel_Bottom.TabIndex = 3;
            // 
            // Panel_Employees
            // 
            this.Panel_Employees.AutoScroll = true;
            this.Panel_Employees.Location = new System.Drawing.Point(450, 90);
            this.Panel_Employees.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Employees.Name = "Panel_Employees";
            this.Panel_Employees.Size = new System.Drawing.Size(350, 600);
            this.Panel_Employees.TabIndex = 4;
            // 
            // Form_ProjectLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.Panel_Employees);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Baslik);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Panel_Project);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ProjectLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ProjectLogin";
            this.Load += new System.EventHandler(this.Form_ProjectLogin_Load);
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.Panel_Baslik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_EmployeesCardAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ProjectCardAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Project;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Baslik;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label lbl_EmployeesBaslik;
        private System.Windows.Forms.Label lbl_ProjectBaslik;
        private System.Windows.Forms.Panel Panel_Employees;
        private System.Windows.Forms.PictureBox btn_ProjectCardAdd;
        private System.Windows.Forms.PictureBox btn_EmployeesCardAdd;
    }
}