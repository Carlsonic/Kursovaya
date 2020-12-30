
namespace kursovaya_rabota
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapa = new GMap.NET.WindowsForms.GMapControl();
            this.Sidemenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.filterlist = new System.Windows.Forms.Panel();
            this.filteroption2 = new System.Windows.Forms.Button();
            this.filteroption1 = new System.Windows.Forms.Button();
            this.filterbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.txtlon = new System.Windows.Forms.TextBox();
            this.Sidemenu.SuspendLayout();
            this.filterlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapa
            // 
            this.mapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mapa.Bearing = 0F;
            this.mapa.CanDragMap = true;
            this.mapa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mapa.Dock = System.Windows.Forms.DockStyle.Right;
            this.mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapa.GrayScaleMode = true;
            this.mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapa.LevelsKeepInMemory = 5;
            this.mapa.Location = new System.Drawing.Point(200, 0);
            this.mapa.MarkersEnabled = true;
            this.mapa.MaxZoom = 2;
            this.mapa.MinZoom = 2;
            this.mapa.MouseWheelZoomEnabled = true;
            this.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapa.Name = "mapa";
            this.mapa.NegativeMode = false;
            this.mapa.PolygonsEnabled = true;
            this.mapa.RetryLoadTile = 0;
            this.mapa.RoutesEnabled = true;
            this.mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapa.ShowTileGridLines = false;
            this.mapa.Size = new System.Drawing.Size(808, 601);
            this.mapa.TabIndex = 7;
            this.mapa.Zoom = 0D;
            this.mapa.Load += new System.EventHandler(this.mapa_Load);
            // 
            // Sidemenu
            // 
            this.Sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(48)))));
            this.Sidemenu.Controls.Add(this.button1);
            this.Sidemenu.Controls.Add(this.filterlist);
            this.Sidemenu.Controls.Add(this.filterbutton);
            this.Sidemenu.Controls.Add(this.panel2);
            this.Sidemenu.Controls.Add(this.btn);
            this.Sidemenu.Controls.Add(this.txtlat);
            this.Sidemenu.Controls.Add(this.txtlon);
            this.Sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidemenu.Location = new System.Drawing.Point(0, 0);
            this.Sidemenu.Name = "Sidemenu";
            this.Sidemenu.Size = new System.Drawing.Size(200, 601);
            this.Sidemenu.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(0, 192);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Кнопка";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // filterlist
            // 
            this.filterlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(91)))), ((int)(((byte)(131)))));
            this.filterlist.Controls.Add(this.filteroption2);
            this.filterlist.Controls.Add(this.filteroption1);
            this.filterlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterlist.Location = new System.Drawing.Point(0, 110);
            this.filterlist.Name = "filterlist";
            this.filterlist.Size = new System.Drawing.Size(200, 82);
            this.filterlist.TabIndex = 8;
            // 
            // filteroption2
            // 
            this.filteroption2.Dock = System.Windows.Forms.DockStyle.Top;
            this.filteroption2.FlatAppearance.BorderSize = 0;
            this.filteroption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filteroption2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filteroption2.Location = new System.Drawing.Point(0, 40);
            this.filteroption2.Name = "filteroption2";
            this.filteroption2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filteroption2.Size = new System.Drawing.Size(200, 40);
            this.filteroption2.TabIndex = 1;
            this.filteroption2.Text = "button2";
            this.filteroption2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filteroption2.UseVisualStyleBackColor = true;
            this.filteroption2.Click += new System.EventHandler(this.filteroption2_Click);
            // 
            // filteroption1
            // 
            this.filteroption1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filteroption1.FlatAppearance.BorderSize = 0;
            this.filteroption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filteroption1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filteroption1.Location = new System.Drawing.Point(0, 0);
            this.filteroption1.Name = "filteroption1";
            this.filteroption1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filteroption1.Size = new System.Drawing.Size(200, 40);
            this.filteroption1.TabIndex = 0;
            this.filteroption1.Text = "button1";
            this.filteroption1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filteroption1.UseVisualStyleBackColor = true;
            this.filteroption1.Click += new System.EventHandler(this.filteroption1_Click);
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            this.filterbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterbutton.FlatAppearance.BorderSize = 0;
            this.filterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterbutton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filterbutton.Location = new System.Drawing.Point(0, 65);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.filterbutton.Size = new System.Drawing.Size(200, 45);
            this.filterbutton.TabIndex = 7;
            this.filterbutton.Text = "Фильтр";
            this.filterbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterbutton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 65);
            this.panel2.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Location = new System.Drawing.Point(0, 519);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(199, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "BTN";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txtlat
            // 
            this.txtlat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlat.Location = new System.Drawing.Point(0, 449);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(200, 20);
            this.txtlat.TabIndex = 2;
            this.txtlat.Text = "0";
            // 
            // txtlon
            // 
            this.txtlon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlon.Location = new System.Drawing.Point(0, 484);
            this.txtlon.Name = "txtlon";
            this.txtlon.Size = new System.Drawing.Size(200, 20);
            this.txtlon.TabIndex = 4;
            this.txtlon.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.Sidemenu);
            this.Controls.Add(this.mapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sidemenu.ResumeLayout(false);
            this.Sidemenu.PerformLayout();
            this.filterlist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapa;
        private System.Windows.Forms.Panel Sidemenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel filterlist;
        private System.Windows.Forms.Button filteroption2;
        private System.Windows.Forms.Button filteroption1;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.TextBox txtlon;
    }
}

