namespace WinAppDirect
{
    partial class WinAppDirect
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAppDirect));
            this.MainTable = new System.Windows.Forms.Label();
            this.winAppDirectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.winAppDirectDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ListMainT = new System.Windows.Forms.ListBox();
            this.MyVAR = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.winAppDirectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winAppDirectDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AutoSize = true;
            this.MainTable.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTable.ForeColor = System.Drawing.Color.GreenYellow;
            this.MainTable.Location = new System.Drawing.Point(12, 9);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(95, 20);
            this.MainTable.TabIndex = 0;
            this.MainTable.Text = "Table MainT";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // ListMainT
            // 
            this.ListMainT.FormattingEnabled = true;
            this.ListMainT.Location = new System.Drawing.Point(16, 46);
            this.ListMainT.Name = "ListMainT";
            this.ListMainT.Size = new System.Drawing.Size(124, 199);
            this.ListMainT.TabIndex = 1;
            this.ListMainT.SelectedIndexChanged += new System.EventHandler(this.ListMainT_SelectedIndexChanged);
            // 
            // MyVAR
            // 
            this.MyVAR.AutoSize = true;
            this.MyVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyVAR.ForeColor = System.Drawing.Color.Yellow;
            this.MyVAR.Location = new System.Drawing.Point(269, 29);
            this.MyVAR.Name = "MyVAR";
            this.MyVAR.Size = new System.Drawing.Size(133, 39);
            this.MyVAR.TabIndex = 2;
            this.MyVAR.Text = "MyVAR";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(267, 200);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // WinAppDirect
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(626, 408);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.MyVAR);
            this.Controls.Add(this.ListMainT);
            this.Controls.Add(this.MainTable);
            this.Name = "WinAppDirect";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "WinAppDirect";
            this.Load += new System.EventHandler(this.WinAppDirect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winAppDirectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winAppDirectDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTable;
        private System.Windows.Forms.BindingSource winAppDirectDataSetBindingSource;
        private System.Windows.Forms.BindingSource winAppDirectDataSetBindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox ListMainT;
        private System.Windows.Forms.Label MyVAR;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

