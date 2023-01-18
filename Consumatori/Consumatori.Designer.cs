
namespace Consumatori
{
    partial class Consumatori
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
            this.btnConsumator = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListaCosturi = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.txtMaiMareDecat = new System.Windows.Forms.TextBox();
            this.cbmConsumatori = new System.Windows.Forms.ComboBox();
            this.ListaAfisare = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Detalii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsumator
            // 
            this.btnConsumator.Location = new System.Drawing.Point(4, 244);
            this.btnConsumator.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumator.Name = "btnConsumator";
            this.btnConsumator.Size = new System.Drawing.Size(217, 69);
            this.btnConsumator.TabIndex = 0;
            this.btnConsumator.Text = "Sorteaza folosind numele consumatorului";
            this.btnConsumator.UseVisualStyleBackColor = true;
            this.btnConsumator.Click += new System.EventHandler(this.btnConsumator_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 261);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mai mare decat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnListaCosturi
            // 
            this.btnListaCosturi.Location = new System.Drawing.Point(591, 222);
            this.btnListaCosturi.Margin = new System.Windows.Forms.Padding(4);
            this.btnListaCosturi.Name = "btnListaCosturi";
            this.btnListaCosturi.Size = new System.Drawing.Size(262, 31);
            this.btnListaCosturi.TabIndex = 0;
            this.btnListaCosturi.Text = "Lista Costurilor Clientilor";
            this.btnListaCosturi.UseVisualStyleBackColor = true;
            this.btnListaCosturi.Click += new System.EventHandler(this.btnListaCosturi_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.Location = new System.Drawing.Point(591, 183);
            this.btnComenzi.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(262, 31);
            this.btnComenzi.TabIndex = 0;
            this.btnComenzi.Text = "Total Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = true;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // txtMaiMareDecat
            // 
            this.txtMaiMareDecat.Location = new System.Drawing.Point(461, 265);
            this.txtMaiMareDecat.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaiMareDecat.Name = "txtMaiMareDecat";
            this.txtMaiMareDecat.Size = new System.Drawing.Size(95, 33);
            this.txtMaiMareDecat.TabIndex = 1;
            // 
            // cbmConsumatori
            // 
            this.cbmConsumatori.AutoCompleteCustomSource.AddRange(new string[] {
            "Iosif",
            "Carmen",
            "Cristian",
            "Andreea"});
            this.cbmConsumatori.FormattingEnabled = true;
            this.cbmConsumatori.Items.AddRange(new object[] {
            "Andrei",
            "Marius",
            "George",
            "Enache",
            "Mihai",
            "Aurel",
            "Adrian",
            "Spiridon"});
            this.cbmConsumatori.Location = new System.Drawing.Point(238, 261);
            this.cbmConsumatori.Margin = new System.Windows.Forms.Padding(4);
            this.cbmConsumatori.Name = "cbmConsumatori";
            this.cbmConsumatori.Size = new System.Drawing.Size(199, 37);
            this.cbmConsumatori.TabIndex = 3;
            this.cbmConsumatori.SelectedIndexChanged += new System.EventHandler(this.cbmConsumatori_SelectedIndexChanged);
            // 
            // ListaAfisare
            // 
            this.ListaAfisare.FormattingEnabled = true;
            this.ListaAfisare.ItemHeight = 29;
            this.ListaAfisare.Location = new System.Drawing.Point(4, 353);
            this.ListaAfisare.Margin = new System.Windows.Forms.Padding(4);
            this.ListaAfisare.Name = "ListaAfisare";
            this.ListaAfisare.Size = new System.Drawing.Size(433, 236);
            this.ListaAfisare.TabIndex = 4;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(522, 556);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(70, 33);
            this.searchTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(638, 539);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(200, 50);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Cautare cu text";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Detalii});
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.listView1.Location = new System.Drawing.Point(490, 341);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 192);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Detalii
            // 
            this.Detalii.Text = "                            ID/Nume/Suma";
            this.Detalii.Width = 360;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(860, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(401, 33);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2023, 1, 18, 10, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Consumatori.Properties.Resources.Screenshot_2023_01_10_232735;
            this.pictureBox1.Location = new System.Drawing.Point(860, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(634, 538);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Consumatori.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(238, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(263, 183);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Consumatori.Properties.Resources.Screenshot_2023_01_10_215709;
            this.pictureBox3.Location = new System.Drawing.Point(238, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(576, 33);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Consumatori.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 225);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Consumatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1520, 657);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ListaAfisare);
            this.Controls.Add(this.cbmConsumatori);
            this.Controls.Add(this.txtMaiMareDecat);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnListaCosturi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConsumator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consumatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumatori";
            this.Load += new System.EventHandler(this.Consumatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsumator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnListaCosturi;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.TextBox txtMaiMareDecat;
        private System.Windows.Forms.ComboBox cbmConsumatori;
        private System.Windows.Forms.ListBox ListaAfisare;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Detalii;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

