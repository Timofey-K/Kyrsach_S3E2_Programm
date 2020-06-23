namespace Kyrsach_K3S2_V1
{
    partial class MainForm
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
            this.btnProdaja = new System.Windows.Forms.Button();
            this.btnMerop = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddWeapon = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(12, 12);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(220, 45);
            this.btnProdaja.TabIndex = 0;
            this.btnProdaja.Text = "Продажа";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // btnMerop
            // 
            this.btnMerop.Location = new System.Drawing.Point(12, 63);
            this.btnMerop.Name = "btnMerop";
            this.btnMerop.Size = new System.Drawing.Size(220, 45);
            this.btnMerop.TabIndex = 1;
            this.btnMerop.Text = "Мероприятия";
            this.btnMerop.UseVisualStyleBackColor = true;
            this.btnMerop.Click += new System.EventHandler(this.btnMerop_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(12, 114);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(220, 45);
            this.btnRest.TabIndex = 2;
            this.btnRest.Text = "Реставрация";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 165);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(220, 45);
            this.btnAddClient.TabIndex = 3;
            this.btnAddClient.Text = "Добавить Клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddWeapon
            // 
            this.btnAddWeapon.Location = new System.Drawing.Point(12, 216);
            this.btnAddWeapon.Name = "btnAddWeapon";
            this.btnAddWeapon.Size = new System.Drawing.Size(220, 45);
            this.btnAddWeapon.TabIndex = 4;
            this.btnAddWeapon.Text = "Добавить Оружие";
            this.btnAddWeapon.UseVisualStyleBackColor = true;
            this.btnAddWeapon.Click += new System.EventHandler(this.btnAddWeapon_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(12, 267);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(220, 45);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Журнал операций";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 320);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnAddWeapon);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnMerop);
            this.Controls.Add(this.btnProdaja);
            this.Name = "MainForm";
            this.Text = "Магазин";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdaja;
        private System.Windows.Forms.Button btnMerop;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddWeapon;
        private System.Windows.Forms.Button btnLog;
    }
}

