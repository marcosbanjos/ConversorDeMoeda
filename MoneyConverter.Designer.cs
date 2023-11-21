namespace moneyConverter
{
    partial class MoneyConverter
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbMoeda = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblValorConvertido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 116);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(401, 26);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbMoeda
            // 
            this.cmbMoeda.FormattingEnabled = true;
            this.cmbMoeda.Items.AddRange(new object[] {
            "Real",
            "Euro"});
            this.cmbMoeda.Location = new System.Drawing.Point(12, 183);
            this.cmbMoeda.Name = "cmbMoeda";
            this.cmbMoeda.Size = new System.Drawing.Size(401, 28);
            this.cmbMoeda.TabIndex = 1;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConverter.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(134, 287);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(156, 47);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblValorConvertido
            // 
            this.lblValorConvertido.BackColor = System.Drawing.Color.White;
            this.lblValorConvertido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorConvertido.Location = new System.Drawing.Point(8, 441);
            this.lblValorConvertido.Name = "lblValorConvertido";
            this.lblValorConvertido.Size = new System.Drawing.Size(401, 36);
            this.lblValorConvertido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convertendo Dolar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Moeda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado:";
            // 
            // MoneyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(425, 578);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorConvertido);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cmbMoeda);
            this.Controls.Add(this.txtValor);
            this.Name = "MoneyConverter";
            this.Text = "MoneyConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbMoeda;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblValorConvertido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}