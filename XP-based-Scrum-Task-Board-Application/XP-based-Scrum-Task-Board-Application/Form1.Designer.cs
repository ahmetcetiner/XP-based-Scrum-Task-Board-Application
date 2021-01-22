namespace XP_based_Scrum_Task_Board_Application
{
    partial class Form_Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Todo = new System.Windows.Forms.Panel();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.Panel_Bottom = new System.Windows.Forms.Panel();
            this.Panel_InProgress = new System.Windows.Forms.Panel();
            this.Panel_Revison = new System.Windows.Forms.Panel();
            this.Panel_Check = new System.Windows.Forms.Panel();
            this.Panel_Done = new System.Windows.Forms.Panel();
            this.Panel_Başlık = new System.Windows.Forms.Panel();
            this.btn_DoneCardAdd = new System.Windows.Forms.PictureBox();
            this.btn_CheckCardAdd = new System.Windows.Forms.PictureBox();
            this.btn_RevisonCardAdd = new System.Windows.Forms.PictureBox();
            this.btn_InProgressCardAdd = new System.Windows.Forms.PictureBox();
            this.btn_TodoCardAdd = new System.Windows.Forms.PictureBox();
            this.lbl_DoneBaslik = new System.Windows.Forms.Label();
            this.lbl_CheckBaslik = new System.Windows.Forms.Label();
            this.lbl_RevisonBaslik = new System.Windows.Forms.Label();
            this.lbl_InProgressBaslik = new System.Windows.Forms.Label();
            this.lbl_TodoBaslik = new System.Windows.Forms.Label();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.Panel_Başlık.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_DoneCardAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CheckCardAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RevisonCardAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InProgressCardAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TodoCardAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Todo
            // 
            this.Panel_Todo.AllowDrop = true;
            this.Panel_Todo.AutoScroll = true;
            this.Panel_Todo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.Panel_Todo.Location = new System.Drawing.Point(0, 90);
            this.Panel_Todo.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Todo.Name = "Panel_Todo";
            this.Panel_Todo.Size = new System.Drawing.Size(300, 700);
            this.Panel_Todo.TabIndex = 0;
            this.Panel_Todo.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.Panel_Todo.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.Panel_Todo.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Panel_Top.Controls.Add(this.btn_Close);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(1500, 40);
            this.Panel_Top.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Close.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_shutdown_2;
            this.btn_Close.ImageLocation = "";
            this.btn_Close.Location = new System.Drawing.Point(1462, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(35, 35);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // Panel_Bottom
            // 
            this.Panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.Panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Bottom.Location = new System.Drawing.Point(0, 790);
            this.Panel_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Bottom.Name = "Panel_Bottom";
            this.Panel_Bottom.Size = new System.Drawing.Size(1500, 10);
            this.Panel_Bottom.TabIndex = 2;
            // 
            // Panel_InProgress
            // 
            this.Panel_InProgress.AllowDrop = true;
            this.Panel_InProgress.AutoScroll = true;
            this.Panel_InProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.Panel_InProgress.Location = new System.Drawing.Point(300, 90);
            this.Panel_InProgress.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_InProgress.Name = "Panel_InProgress";
            this.Panel_InProgress.Size = new System.Drawing.Size(300, 700);
            this.Panel_InProgress.TabIndex = 3;
            this.Panel_InProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.Panel_InProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.Panel_InProgress.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // Panel_Revison
            // 
            this.Panel_Revison.AllowDrop = true;
            this.Panel_Revison.AutoScroll = true;
            this.Panel_Revison.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.Panel_Revison.Location = new System.Drawing.Point(600, 90);
            this.Panel_Revison.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Revison.Name = "Panel_Revison";
            this.Panel_Revison.Size = new System.Drawing.Size(300, 700);
            this.Panel_Revison.TabIndex = 4;
            this.Panel_Revison.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.Panel_Revison.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.Panel_Revison.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // Panel_Check
            // 
            this.Panel_Check.AllowDrop = true;
            this.Panel_Check.AutoScroll = true;
            this.Panel_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.Panel_Check.Location = new System.Drawing.Point(900, 90);
            this.Panel_Check.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Check.Name = "Panel_Check";
            this.Panel_Check.Size = new System.Drawing.Size(300, 700);
            this.Panel_Check.TabIndex = 5;
            this.Panel_Check.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.Panel_Check.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.Panel_Check.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // Panel_Done
            // 
            this.Panel_Done.AllowDrop = true;
            this.Panel_Done.AutoScroll = true;
            this.Panel_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(3)))));
            this.Panel_Done.Location = new System.Drawing.Point(1200, 90);
            this.Panel_Done.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Done.Name = "Panel_Done";
            this.Panel_Done.Size = new System.Drawing.Size(300, 700);
            this.Panel_Done.TabIndex = 6;
            this.Panel_Done.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.Panel_Done.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            this.Panel_Done.DragLeave += new System.EventHandler(this.panel_DragLeave);
            // 
            // Panel_Başlık
            // 
            this.Panel_Başlık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(193)))), ((int)(((byte)(172)))));
            this.Panel_Başlık.Controls.Add(this.btn_DoneCardAdd);
            this.Panel_Başlık.Controls.Add(this.btn_CheckCardAdd);
            this.Panel_Başlık.Controls.Add(this.btn_RevisonCardAdd);
            this.Panel_Başlık.Controls.Add(this.btn_InProgressCardAdd);
            this.Panel_Başlık.Controls.Add(this.btn_TodoCardAdd);
            this.Panel_Başlık.Controls.Add(this.lbl_DoneBaslik);
            this.Panel_Başlık.Controls.Add(this.lbl_CheckBaslik);
            this.Panel_Başlık.Controls.Add(this.lbl_RevisonBaslik);
            this.Panel_Başlık.Controls.Add(this.lbl_InProgressBaslik);
            this.Panel_Başlık.Controls.Add(this.lbl_TodoBaslik);
            this.Panel_Başlık.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Başlık.Location = new System.Drawing.Point(0, 40);
            this.Panel_Başlık.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Başlık.Name = "Panel_Başlık";
            this.Panel_Başlık.Size = new System.Drawing.Size(1500, 50);
            this.Panel_Başlık.TabIndex = 7;
            // 
            // btn_DoneCardAdd
            // 
            this.btn_DoneCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DoneCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_DoneCardAdd.ImageLocation = "";
            this.btn_DoneCardAdd.Location = new System.Drawing.Point(1480, 3);
            this.btn_DoneCardAdd.Name = "btn_DoneCardAdd";
            this.btn_DoneCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_DoneCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_DoneCardAdd.TabIndex = 2;
            this.btn_DoneCardAdd.TabStop = false;
            this.btn_DoneCardAdd.Click += new System.EventHandler(this.btn_DoneCardAdd_Click);
            // 
            // btn_CheckCardAdd
            // 
            this.btn_CheckCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CheckCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_CheckCardAdd.ImageLocation = "";
            this.btn_CheckCardAdd.Location = new System.Drawing.Point(1180, 3);
            this.btn_CheckCardAdd.Name = "btn_CheckCardAdd";
            this.btn_CheckCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_CheckCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_CheckCardAdd.TabIndex = 7;
            this.btn_CheckCardAdd.TabStop = false;
            this.btn_CheckCardAdd.Click += new System.EventHandler(this.btn_CheckCardAdd_Click);
            // 
            // btn_RevisonCardAdd
            // 
            this.btn_RevisonCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_RevisonCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_RevisonCardAdd.ImageLocation = "";
            this.btn_RevisonCardAdd.Location = new System.Drawing.Point(880, 3);
            this.btn_RevisonCardAdd.Name = "btn_RevisonCardAdd";
            this.btn_RevisonCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_RevisonCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_RevisonCardAdd.TabIndex = 6;
            this.btn_RevisonCardAdd.TabStop = false;
            this.btn_RevisonCardAdd.Click += new System.EventHandler(this.btn_RevisonCardAdd_Click);
            // 
            // btn_InProgressCardAdd
            // 
            this.btn_InProgressCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InProgressCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_InProgressCardAdd.ImageLocation = "";
            this.btn_InProgressCardAdd.Location = new System.Drawing.Point(580, 3);
            this.btn_InProgressCardAdd.Name = "btn_InProgressCardAdd";
            this.btn_InProgressCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_InProgressCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_InProgressCardAdd.TabIndex = 5;
            this.btn_InProgressCardAdd.TabStop = false;
            this.btn_InProgressCardAdd.Click += new System.EventHandler(this.btn_InProgressCardAdd_Click);
            // 
            // btn_TodoCardAdd
            // 
            this.btn_TodoCardAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_TodoCardAdd.Image = global::XP_based_Scrum_Task_Board_Application.Properties.Resources.icons8_plus_math_1;
            this.btn_TodoCardAdd.ImageLocation = "";
            this.btn_TodoCardAdd.Location = new System.Drawing.Point(280, 3);
            this.btn_TodoCardAdd.Name = "btn_TodoCardAdd";
            this.btn_TodoCardAdd.Size = new System.Drawing.Size(20, 20);
            this.btn_TodoCardAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_TodoCardAdd.TabIndex = 1;
            this.btn_TodoCardAdd.TabStop = false;
            this.btn_TodoCardAdd.Click += new System.EventHandler(this.btn_TodoCardAdd_Click);
            // 
            // lbl_DoneBaslik
            // 
            this.lbl_DoneBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DoneBaslik.Location = new System.Drawing.Point(1220, 0);
            this.lbl_DoneBaslik.Name = "lbl_DoneBaslik";
            this.lbl_DoneBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_DoneBaslik.TabIndex = 4;
            this.lbl_DoneBaslik.Text = "DONE";
            this.lbl_DoneBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckBaslik
            // 
            this.lbl_CheckBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CheckBaslik.Location = new System.Drawing.Point(920, 0);
            this.lbl_CheckBaslik.Name = "lbl_CheckBaslik";
            this.lbl_CheckBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_CheckBaslik.TabIndex = 3;
            this.lbl_CheckBaslik.Text = "CHECK";
            this.lbl_CheckBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RevisonBaslik
            // 
            this.lbl_RevisonBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_RevisonBaslik.Location = new System.Drawing.Point(620, 0);
            this.lbl_RevisonBaslik.Name = "lbl_RevisonBaslik";
            this.lbl_RevisonBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_RevisonBaslik.TabIndex = 2;
            this.lbl_RevisonBaslik.Text = "REVISON";
            this.lbl_RevisonBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InProgressBaslik
            // 
            this.lbl_InProgressBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_InProgressBaslik.Location = new System.Drawing.Point(320, 0);
            this.lbl_InProgressBaslik.Name = "lbl_InProgressBaslik";
            this.lbl_InProgressBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_InProgressBaslik.TabIndex = 1;
            this.lbl_InProgressBaslik.Text = "IN PROGRESS";
            this.lbl_InProgressBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TodoBaslik
            // 
            this.lbl_TodoBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_TodoBaslik.Location = new System.Drawing.Point(20, 0);
            this.lbl_TodoBaslik.Name = "lbl_TodoBaslik";
            this.lbl_TodoBaslik.Size = new System.Drawing.Size(260, 50);
            this.lbl_TodoBaslik.TabIndex = 0;
            this.lbl_TodoBaslik.Text = "TODO";
            this.lbl_TodoBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.Panel_Başlık);
            this.Controls.Add(this.Panel_Done);
            this.Controls.Add(this.Panel_Check);
            this.Controls.Add(this.Panel_Revison);
            this.Controls.Add(this.Panel_InProgress);
            this.Controls.Add(this.Panel_Bottom);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Panel_Todo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.Panel_Başlık.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_DoneCardAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CheckCardAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RevisonCardAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_InProgressCardAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TodoCardAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Todo;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Bottom;
        private System.Windows.Forms.Panel Panel_InProgress;
        private System.Windows.Forms.Panel Panel_Revison;
        private System.Windows.Forms.Panel Panel_Check;
        private System.Windows.Forms.Panel Panel_Done;
        private System.Windows.Forms.Panel Panel_Başlık;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label lbl_DoneBaslik;
        private System.Windows.Forms.Label lbl_CheckBaslik;
        private System.Windows.Forms.Label lbl_RevisonBaslik;
        private System.Windows.Forms.Label lbl_InProgressBaslik;
        private System.Windows.Forms.Label lbl_TodoBaslik;
        private System.Windows.Forms.PictureBox btn_TodoCardAdd;
        private System.Windows.Forms.PictureBox btn_DoneCardAdd;
        private System.Windows.Forms.PictureBox btn_CheckCardAdd;
        private System.Windows.Forms.PictureBox btn_RevisonCardAdd;
        private System.Windows.Forms.PictureBox btn_InProgressCardAdd;
    }
}

