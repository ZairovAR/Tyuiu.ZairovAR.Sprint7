namespace Tyuiu.ZariovAR.Sprint7
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.panelone = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.paneltwo = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.timermenu = new System.Windows.Forms.Timer(this.components);
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonWinow = new System.Windows.Forms.Button();
            this.X_butten = new System.Windows.Forms.Button();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonPopulation = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonterritory = new System.Windows.Forms.Button();
            this.panelone.SuspendLayout();
            this.paneltwo.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelone
            // 
            this.panelone.Controls.Add(this.panelMenu);
            this.panelone.Controls.Add(this.paneltwo);
            this.panelone.Controls.Add(this.flowLayoutPanelMenu);
            this.panelone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelone.Location = new System.Drawing.Point(0, 0);
            this.panelone.Name = "panelone";
            this.panelone.Size = new System.Drawing.Size(1118, 615);
            this.panelone.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(192, 45);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(926, 570);
            this.panelMenu.TabIndex = 2;
            // 
            // paneltwo
            // 
            this.paneltwo.BackColor = System.Drawing.Color.Moccasin;
            this.paneltwo.Controls.Add(this.buttonMin);
            this.paneltwo.Controls.Add(this.buttonWinow);
            this.paneltwo.Controls.Add(this.X_butten);
            this.paneltwo.Controls.Add(this.pictureBoxMenu);
            this.paneltwo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltwo.Location = new System.Drawing.Point(192, 0);
            this.paneltwo.Name = "paneltwo";
            this.paneltwo.Size = new System.Drawing.Size(926, 45);
            this.paneltwo.TabIndex = 1;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.LightBlue;
            this.flowLayoutPanelMenu.Controls.Add(this.pictureBoxLogo);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonPopulation);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonMoney);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonterritory);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(192, 615);
            this.flowLayoutPanelMenu.TabIndex = 0;
            // 
            // timermenu
            // 
            this.timermenu.Tick += new System.EventHandler(this.timermenu_Tick);
            // 
            // buttonMin
            // 
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources._1904666_calculate_close_delete_hide_minimize_minus_remove_122516__1_;
            this.buttonMin.Location = new System.Drawing.Point(787, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(47, 45);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonWinow
            // 
            this.buttonWinow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWinow.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonWinow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWinow.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources.window_maximize_icon_137012;
            this.buttonWinow.Location = new System.Drawing.Point(834, 0);
            this.buttonWinow.Name = "buttonWinow";
            this.buttonWinow.Size = new System.Drawing.Size(47, 45);
            this.buttonWinow.TabIndex = 3;
            this.buttonWinow.UseVisualStyleBackColor = true;
            this.buttonWinow.Click += new System.EventHandler(this.buttonWinow_Click);
            // 
            // X_butten
            // 
            this.X_butten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.X_butten.Dock = System.Windows.Forms.DockStyle.Right;
            this.X_butten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X_butten.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.X_butten.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources._1492790919_81power_84209;
            this.X_butten.Location = new System.Drawing.Point(881, 0);
            this.X_butten.Name = "X_butten";
            this.X_butten.Size = new System.Drawing.Size(45, 45);
            this.X_butten.TabIndex = 2;
            this.X_butten.UseVisualStyleBackColor = true;
            this.X_butten.Click += new System.EventHandler(this.X_butten_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMenu.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources.dot_checklist_list_todo_icon_226578__2_;
            this.pictureBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(82, 45);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources.cyclone_weather_world_time_icon_194253;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(189, 75);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonPopulation
            // 
            this.buttonPopulation.BackColor = System.Drawing.Color.Moccasin;
            this.buttonPopulation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPopulation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPopulation.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPopulation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPopulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPopulation.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources.ageing_population_more_than_youth_icon_161480;
            this.buttonPopulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPopulation.Location = new System.Drawing.Point(3, 84);
            this.buttonPopulation.Name = "buttonPopulation";
            this.buttonPopulation.Size = new System.Drawing.Size(189, 51);
            this.buttonPopulation.TabIndex = 1;
            this.buttonPopulation.Text = "     Население ";
            this.buttonPopulation.UseVisualStyleBackColor = false;
            this.buttonPopulation.Click += new System.EventHandler(this.buttonPopulation_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.Moccasin;
            this.buttonMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMoney.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources._3925436_economy_graph_statistics_icon_111564;
            this.buttonMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoney.Location = new System.Drawing.Point(3, 141);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(189, 50);
            this.buttonMoney.TabIndex = 2;
            this.buttonMoney.Text = "     Экономика";
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonterritory
            // 
            this.buttonterritory.BackColor = System.Drawing.Color.Moccasin;
            this.buttonterritory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonterritory.Image = global::Tyuiu.ZariovAR.Sprint7.Properties.Resources.map_search_outline_icon_139024;
            this.buttonterritory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonterritory.Location = new System.Drawing.Point(3, 197);
            this.buttonterritory.Name = "buttonterritory";
            this.buttonterritory.Size = new System.Drawing.Size(189, 43);
            this.buttonterritory.TabIndex = 3;
            this.buttonterritory.Text = "       Территория";
            this.buttonterritory.UseVisualStyleBackColor = false;
            this.buttonterritory.Click += new System.EventHandler(this.buttonterritory_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 615);
            this.Controls.Add(this.panelone);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMein";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelone.ResumeLayout(false);
            this.paneltwo.ResumeLayout(false);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelone;
        private System.Windows.Forms.Panel paneltwo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonPopulation;
        private System.Windows.Forms.Timer timermenu;
        private System.Windows.Forms.Button X_butten;
        private System.Windows.Forms.Button buttonWinow;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonterritory;
    }
}

