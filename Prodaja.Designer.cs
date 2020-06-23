namespace Kyrsach_K3S2_V1
{
    partial class Prodaja
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
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.ctlWorker = new System.Windows.Forms.ComboBox();
            this.ctlClient = new System.Windows.Forms.ComboBox();
            this.btnOtmena = new System.Windows.Forms.Button();
            this.dgvWeapon = new System.Windows.Forms.DataGridView();
            this.Продать = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ctlTip = new System.Windows.Forms.ComboBox();
            this.ctlQuality = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(9, 9);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(60, 13);
            this.lblWorker.TabIndex = 2;
            this.lblWorker.Text = "Сотрудник";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(751, 114);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Клиент";
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(754, 157);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(110, 23);
            this.btnProdaja.TabIndex = 8;
            this.btnProdaja.Text = "Продать";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // ctlWorker
            // 
            this.ctlWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlWorker.FormattingEnabled = true;
            this.ctlWorker.Location = new System.Drawing.Point(12, 25);
            this.ctlWorker.Name = "ctlWorker";
            this.ctlWorker.Size = new System.Drawing.Size(274, 21);
            this.ctlWorker.TabIndex = 10;
            // 
            // ctlClient
            // 
            this.ctlClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlClient.FormattingEnabled = true;
            this.ctlClient.Location = new System.Drawing.Point(754, 130);
            this.ctlClient.Name = "ctlClient";
            this.ctlClient.Size = new System.Drawing.Size(222, 21);
            this.ctlClient.TabIndex = 11;
            // 
            // btnOtmena
            // 
            this.btnOtmena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtmena.Location = new System.Drawing.Point(754, 458);
            this.btnOtmena.Name = "btnOtmena";
            this.btnOtmena.Size = new System.Drawing.Size(120, 23);
            this.btnOtmena.TabIndex = 12;
            this.btnOtmena.Text = "Выход";
            this.btnOtmena.UseVisualStyleBackColor = true;
            // 
            // dgvWeapon
            // 
            this.dgvWeapon.AllowUserToAddRows = false;
            this.dgvWeapon.AllowUserToDeleteRows = false;
            this.dgvWeapon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeapon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Продать});
            this.dgvWeapon.Location = new System.Drawing.Point(12, 114);
            this.dgvWeapon.Name = "dgvWeapon";
            this.dgvWeapon.Size = new System.Drawing.Size(703, 367);
            this.dgvWeapon.TabIndex = 17;
            // 
            // Продать
            // 
            this.Продать.HeaderText = "Продать";
            this.Продать.Name = "Продать";
            // 
            // ctlTip
            // 
            this.ctlTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlTip.FormattingEnabled = true;
            this.ctlTip.Location = new System.Drawing.Point(12, 74);
            this.ctlTip.Name = "ctlTip";
            this.ctlTip.Size = new System.Drawing.Size(121, 21);
            this.ctlTip.TabIndex = 18;
            // 
            // ctlQuality
            // 
            this.ctlQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlQuality.FormattingEnabled = true;
            this.ctlQuality.Location = new System.Drawing.Point(168, 74);
            this.ctlQuality.Name = "ctlQuality";
            this.ctlQuality.Size = new System.Drawing.Size(121, 21);
            this.ctlQuality.TabIndex = 19;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(9, 53);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(79, 13);
            this.lblTip.TabIndex = 20;
            this.lblTip.Text = "Выберите Тип";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(165, 53);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(107, 13);
            this.lblQuality.TabIndex = 21;
            this.lblQuality.Text = "Выберите Качество";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(325, 74);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Обновить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 493);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.ctlQuality);
            this.Controls.Add(this.ctlTip);
            this.Controls.Add(this.dgvWeapon);
            this.Controls.Add(this.btnOtmena);
            this.Controls.Add(this.ctlClient);
            this.Controls.Add(this.ctlWorker);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblWorker);
            this.Name = "Prodaja";
            this.Text = "Продажа";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.ComboBox ctlWorker;
        private System.Windows.Forms.ComboBox ctlClient;
        private System.Windows.Forms.Button btnOtmena;
        private System.Windows.Forms.DataGridView dgvWeapon;
        private System.Windows.Forms.ComboBox ctlTip;
        private System.Windows.Forms.ComboBox ctlQuality;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Продать;
    }
}