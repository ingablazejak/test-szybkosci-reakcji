
namespace obrazkitest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.timerstartu = new System.Windows.Forms.Timer(this.components);
            this.labelstart = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.licznikczasu = new System.Windows.Forms.Label();
            this.minimalny = new System.Windows.Forms.Label();
            this.sredni = new System.Windows.Forms.Label();
            this.dziura = new System.Windows.Forms.Button();
            this.zorza = new System.Windows.Forms.Button();
            this.slonce = new System.Windows.Forms.Button();
            this.ksiezyc = new System.Windows.Forms.Button();
            this.ziemia = new System.Windows.Forms.Button();
            this.kometa = new System.Windows.Forms.Button();
            this.galaktyka = new System.Windows.Forms.Button();
            this.jowisz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liczbaProbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lp8 = new System.Windows.Forms.ToolStripMenuItem();
            this.lp10 = new System.Windows.Forms.ToolStripMenuItem();
            this.lp16 = new System.Windows.Forms.ToolStripMenuItem();
            this.lp30 = new System.Windows.Forms.ToolStripMenuItem();
            this.kasujRekordyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjscieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.BackColor = System.Drawing.Color.Black;
            this.obrazek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obrazek.BackgroundImage")));
            this.obrazek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obrazek.Location = new System.Drawing.Point(71, 56);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(300, 300);
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.start.Cursor = System.Windows.Forms.Cursors.Default;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.ForeColor = System.Drawing.Color.Gainsboro;
            this.start.Location = new System.Drawing.Point(19, 610);
            this.start.Margin = new System.Windows.Forms.Padding(0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(405, 53);
            this.start.TabIndex = 1;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // timerstartu
            // 
            this.timerstartu.Interval = 1000;
            this.timerstartu.Tick += new System.EventHandler(this.timerstartu_Tick);
            // 
            // labelstart
            // 
            this.labelstart.AutoSize = true;
            this.labelstart.BackColor = System.Drawing.Color.Transparent;
            this.labelstart.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelstart.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelstart.Location = new System.Drawing.Point(199, 177);
            this.labelstart.Name = "labelstart";
            this.labelstart.Size = new System.Drawing.Size(50, 56);
            this.labelstart.TabIndex = 2;
            this.labelstart.Text = "3";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // licznikczasu
            // 
            this.licznikczasu.AutoSize = true;
            this.licznikczasu.BackColor = System.Drawing.Color.Black;
            this.licznikczasu.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznikczasu.ForeColor = System.Drawing.Color.Gainsboro;
            this.licznikczasu.Location = new System.Drawing.Point(117, 371);
            this.licznikczasu.Name = "licznikczasu";
            this.licznikczasu.Size = new System.Drawing.Size(210, 43);
            this.licznikczasu.TabIndex = 3;
            this.licznikczasu.Text = "czas: 00.00";
            // 
            // minimalny
            // 
            this.minimalny.AutoSize = true;
            this.minimalny.BackColor = System.Drawing.Color.Black;
            this.minimalny.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimalny.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimalny.Location = new System.Drawing.Point(27, 28);
            this.minimalny.Name = "minimalny";
            this.minimalny.Size = new System.Drawing.Size(130, 23);
            this.minimalny.TabIndex = 4;
            this.minimalny.Text = "rekord: 00.00";
            // 
            // sredni
            // 
            this.sredni.AutoSize = true;
            this.sredni.BackColor = System.Drawing.Color.Black;
            this.sredni.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sredni.ForeColor = System.Drawing.Color.Gainsboro;
            this.sredni.Location = new System.Drawing.Point(253, 28);
            this.sredni.Name = "sredni";
            this.sredni.Size = new System.Drawing.Size(127, 23);
            this.sredni.TabIndex = 5;
            this.sredni.Text = "średni: 00.00";
            // 
            // dziura
            // 
            this.dziura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dziura.Cursor = System.Windows.Forms.Cursors.Default;
            this.dziura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dziura.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dziura.ForeColor = System.Drawing.Color.Gainsboro;
            this.dziura.Location = new System.Drawing.Point(0, 0);
            this.dziura.Margin = new System.Windows.Forms.Padding(0);
            this.dziura.Name = "dziura";
            this.dziura.Size = new System.Drawing.Size(150, 45);
            this.dziura.TabIndex = 6;
            this.dziura.Text = "czarna dziura";
            this.dziura.UseVisualStyleBackColor = false;
            this.dziura.Click += new System.EventHandler(this.dziura_Click);
            // 
            // zorza
            // 
            this.zorza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.zorza.Cursor = System.Windows.Forms.Cursors.Default;
            this.zorza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zorza.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zorza.ForeColor = System.Drawing.Color.Gainsboro;
            this.zorza.Location = new System.Drawing.Point(150, 90);
            this.zorza.Margin = new System.Windows.Forms.Padding(0);
            this.zorza.Name = "zorza";
            this.zorza.Size = new System.Drawing.Size(150, 45);
            this.zorza.TabIndex = 7;
            this.zorza.Text = "zorza polarna";
            this.zorza.UseVisualStyleBackColor = false;
            this.zorza.Click += new System.EventHandler(this.zorza_Click);
            // 
            // slonce
            // 
            this.slonce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.slonce.Cursor = System.Windows.Forms.Cursors.Default;
            this.slonce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slonce.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slonce.ForeColor = System.Drawing.Color.Gainsboro;
            this.slonce.Location = new System.Drawing.Point(150, 135);
            this.slonce.Margin = new System.Windows.Forms.Padding(0);
            this.slonce.Name = "slonce";
            this.slonce.Size = new System.Drawing.Size(150, 45);
            this.slonce.TabIndex = 8;
            this.slonce.Text = "słońce";
            this.slonce.UseVisualStyleBackColor = false;
            this.slonce.Click += new System.EventHandler(this.slonce_Click);
            // 
            // ksiezyc
            // 
            this.ksiezyc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ksiezyc.Cursor = System.Windows.Forms.Cursors.Default;
            this.ksiezyc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ksiezyc.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ksiezyc.ForeColor = System.Drawing.Color.Gainsboro;
            this.ksiezyc.Location = new System.Drawing.Point(150, 45);
            this.ksiezyc.Margin = new System.Windows.Forms.Padding(0);
            this.ksiezyc.Name = "ksiezyc";
            this.ksiezyc.Size = new System.Drawing.Size(150, 45);
            this.ksiezyc.TabIndex = 9;
            this.ksiezyc.Text = "księżyc";
            this.ksiezyc.UseVisualStyleBackColor = false;
            this.ksiezyc.Click += new System.EventHandler(this.ksiezyc_Click);
            // 
            // ziemia
            // 
            this.ziemia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ziemia.Cursor = System.Windows.Forms.Cursors.Default;
            this.ziemia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ziemia.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ziemia.ForeColor = System.Drawing.Color.Gainsboro;
            this.ziemia.Location = new System.Drawing.Point(150, 0);
            this.ziemia.Margin = new System.Windows.Forms.Padding(0);
            this.ziemia.Name = "ziemia";
            this.ziemia.Size = new System.Drawing.Size(150, 45);
            this.ziemia.TabIndex = 10;
            this.ziemia.Text = "ziemia";
            this.ziemia.UseVisualStyleBackColor = false;
            this.ziemia.Click += new System.EventHandler(this.neptun_Click);
            // 
            // kometa
            // 
            this.kometa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.kometa.Cursor = System.Windows.Forms.Cursors.Default;
            this.kometa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kometa.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kometa.ForeColor = System.Drawing.Color.Gainsboro;
            this.kometa.Location = new System.Drawing.Point(0, 135);
            this.kometa.Margin = new System.Windows.Forms.Padding(0);
            this.kometa.Name = "kometa";
            this.kometa.Size = new System.Drawing.Size(150, 45);
            this.kometa.TabIndex = 11;
            this.kometa.Text = "kometa";
            this.kometa.UseVisualStyleBackColor = false;
            this.kometa.Click += new System.EventHandler(this.kometa_Click);
            // 
            // galaktyka
            // 
            this.galaktyka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.galaktyka.Cursor = System.Windows.Forms.Cursors.Default;
            this.galaktyka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.galaktyka.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.galaktyka.ForeColor = System.Drawing.Color.Gainsboro;
            this.galaktyka.Location = new System.Drawing.Point(0, 45);
            this.galaktyka.Margin = new System.Windows.Forms.Padding(0);
            this.galaktyka.Name = "galaktyka";
            this.galaktyka.Size = new System.Drawing.Size(150, 45);
            this.galaktyka.TabIndex = 13;
            this.galaktyka.Text = "galaktyka";
            this.galaktyka.UseVisualStyleBackColor = false;
            this.galaktyka.Click += new System.EventHandler(this.galaktyka_Click);
            // 
            // jowisz
            // 
            this.jowisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.jowisz.Cursor = System.Windows.Forms.Cursors.Default;
            this.jowisz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jowisz.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jowisz.ForeColor = System.Drawing.Color.Gainsboro;
            this.jowisz.Location = new System.Drawing.Point(0, 90);
            this.jowisz.Margin = new System.Windows.Forms.Padding(0);
            this.jowisz.Name = "jowisz";
            this.jowisz.Size = new System.Drawing.Size(150, 45);
            this.jowisz.TabIndex = 12;
            this.jowisz.Text = "jowisz";
            this.jowisz.UseVisualStyleBackColor = false;
            this.jowisz.Click += new System.EventHandler(this.jowisz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liczbaProbToolStripMenuItem,
            this.kasujRekordyToolStripMenuItem,
            this.wyjscieToolStripMenuItem});
            this.opcjeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // liczbaProbToolStripMenuItem
            // 
            this.liczbaProbToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.liczbaProbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lp8,
            this.lp10,
            this.lp16,
            this.lp30});
            this.liczbaProbToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.liczbaProbToolStripMenuItem.Name = "liczbaProbToolStripMenuItem";
            this.liczbaProbToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.liczbaProbToolStripMenuItem.Text = "Liczba prób";
            // 
            // lp8
            // 
            this.lp8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lp8.Checked = true;
            this.lp8.CheckOnClick = true;
            this.lp8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lp8.ForeColor = System.Drawing.SystemColors.Control;
            this.lp8.Name = "lp8";
            this.lp8.Size = new System.Drawing.Size(86, 22);
            this.lp8.Text = "8";
            this.lp8.Click += new System.EventHandler(this.lp8_Click);
            // 
            // lp10
            // 
            this.lp10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lp10.CheckOnClick = true;
            this.lp10.ForeColor = System.Drawing.SystemColors.Control;
            this.lp10.Name = "lp10";
            this.lp10.Size = new System.Drawing.Size(86, 22);
            this.lp10.Text = "10";
            this.lp10.Click += new System.EventHandler(this.lp10_Click);
            // 
            // lp16
            // 
            this.lp16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lp16.CheckOnClick = true;
            this.lp16.ForeColor = System.Drawing.SystemColors.Control;
            this.lp16.Name = "lp16";
            this.lp16.Size = new System.Drawing.Size(86, 22);
            this.lp16.Text = "16";
            this.lp16.Click += new System.EventHandler(this.lp16_Click);
            // 
            // lp30
            // 
            this.lp30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lp30.CheckOnClick = true;
            this.lp30.ForeColor = System.Drawing.SystemColors.Control;
            this.lp30.Name = "lp30";
            this.lp30.Size = new System.Drawing.Size(86, 22);
            this.lp30.Text = "30";
            this.lp30.Click += new System.EventHandler(this.lp30_Click);
            // 
            // kasujRekordyToolStripMenuItem
            // 
            this.kasujRekordyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.kasujRekordyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.kasujRekordyToolStripMenuItem.Name = "kasujRekordyToolStripMenuItem";
            this.kasujRekordyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kasujRekordyToolStripMenuItem.Text = "Kasuj Rekordy";
            this.kasujRekordyToolStripMenuItem.Click += new System.EventHandler(this.kasujRekordyToolStripMenuItem_Click);
            // 
            // wyjscieToolStripMenuItem
            // 
            this.wyjscieToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.wyjscieToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.wyjscieToolStripMenuItem.Name = "wyjscieToolStripMenuItem";
            this.wyjscieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.wyjscieToolStripMenuItem.Text = "Wyjście";
            this.wyjscieToolStripMenuItem.Click += new System.EventHandler(this.wyjscieToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dziura);
            this.flowLayoutPanel1.Controls.Add(this.ziemia);
            this.flowLayoutPanel1.Controls.Add(this.galaktyka);
            this.flowLayoutPanel1.Controls.Add(this.ksiezyc);
            this.flowLayoutPanel1.Controls.Add(this.jowisz);
            this.flowLayoutPanel1.Controls.Add(this.zorza);
            this.flowLayoutPanel1.Controls.Add(this.kometa);
            this.flowLayoutPanel1.Controls.Add(this.slonce);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 417);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 181);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 683);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sredni);
            this.Controls.Add(this.minimalny);
            this.Controls.Add(this.licznikczasu);
            this.Controls.Add(this.labelstart);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "test czasu reakcji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timerstartu;
        private System.Windows.Forms.Label labelstart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label licznikczasu;
        private System.Windows.Forms.Label minimalny;
        private System.Windows.Forms.Label sredni;
        private System.Windows.Forms.Button dziura;
        private System.Windows.Forms.Button zorza;
        private System.Windows.Forms.Button slonce;
        private System.Windows.Forms.Button ksiezyc;
        private System.Windows.Forms.Button ziemia;
        private System.Windows.Forms.Button kometa;
        private System.Windows.Forms.Button galaktyka;
        private System.Windows.Forms.Button jowisz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liczbaProbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lp8;
        private System.Windows.Forms.ToolStripMenuItem lp10;
        private System.Windows.Forms.ToolStripMenuItem lp16;
        private System.Windows.Forms.ToolStripMenuItem lp30;
        private System.Windows.Forms.ToolStripMenuItem kasujRekordyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjscieToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

