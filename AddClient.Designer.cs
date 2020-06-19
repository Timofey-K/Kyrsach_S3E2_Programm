namespace Kyrsach_K3S2_V1
{
    partial class AddClient
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(161, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Введите ФИО нового клиента";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(323, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(13, 56);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Телефон";
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(16, 72);
            this.mtbTel.Mask = "80000000000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(320, 20);
            this.mtbTel.TabIndex = 3;
            this.mtbTel.ValidatingType = typeof(int);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить клиента";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Location = new System.Drawing.Point(269, 146);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "Отмена";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Name = "AddClient";
            this.Text = "Новый Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnd;
    }
}