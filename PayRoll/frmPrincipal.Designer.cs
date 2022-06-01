namespace PayRoll
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btCalc = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.lbIncome = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbINSS = new System.Windows.Forms.Label();
            this.lbIRRF = new System.Windows.Forms.Label();
            this.lbLiquidIncome = new System.Windows.Forms.Label();
            this.txtINSSValue = new System.Windows.Forms.TextBox();
            this.txtLiquidIncomeValue = new System.Windows.Forms.TextBox();
            this.txtIRRFValue = new System.Windows.Forms.TextBox();
            this.AliquotaINSS = new System.Windows.Forms.Label();
            this.AliquotaIRRF = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRRF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(48, 112);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(346, 47);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Calcular";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(48, 62);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(346, 26);
            this.txtIncome.TabIndex = 1;
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.Location = new System.Drawing.Point(30, 39);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(177, 20);
            this.lbIncome.TabIndex = 2;
            this.lbIncome.Text = "Informe o Salário Bruto:";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Location = new System.Drawing.Point(30, 210);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(94, 20);
            this.lbDesconto.TabIndex = 3;
            this.lbDesconto.Text = "Descontos :";
            // 
            // lbINSS
            // 
            this.lbINSS.AutoSize = true;
            this.lbINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbINSS.Location = new System.Drawing.Point(15, 311);
            this.lbINSS.Name = "lbINSS";
            this.lbINSS.Size = new System.Drawing.Size(51, 20);
            this.lbINSS.TabIndex = 4;
            this.lbINSS.Text = "INSS";
            // 
            // lbIRRF
            // 
            this.lbIRRF.AutoSize = true;
            this.lbIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIRRF.Location = new System.Drawing.Point(133, 363);
            this.lbIRRF.Name = "lbIRRF";
            this.lbIRRF.Size = new System.Drawing.Size(52, 20);
            this.lbIRRF.TabIndex = 5;
            this.lbIRRF.Text = "IRRF";
            // 
            // lbLiquidIncome
            // 
            this.lbLiquidIncome.AutoSize = true;
            this.lbLiquidIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLiquidIncome.Location = new System.Drawing.Point(251, 415);
            this.lbLiquidIncome.Name = "lbLiquidIncome";
            this.lbLiquidIncome.Size = new System.Drawing.Size(128, 20);
            this.lbLiquidIncome.TabIndex = 6;
            this.lbLiquidIncome.Text = "Salário Liquído";
            // 
            // txtINSSValue
            // 
            this.txtINSSValue.Location = new System.Drawing.Point(33, 334);
            this.txtINSSValue.Name = "txtINSSValue";
            this.txtINSSValue.ReadOnly = true;
            this.txtINSSValue.Size = new System.Drawing.Size(100, 26);
            this.txtINSSValue.TabIndex = 7;
            // 
            // txtLiquidIncomeValue
            // 
            this.txtLiquidIncomeValue.Location = new System.Drawing.Point(309, 438);
            this.txtLiquidIncomeValue.Name = "txtLiquidIncomeValue";
            this.txtLiquidIncomeValue.ReadOnly = true;
            this.txtLiquidIncomeValue.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidIncomeValue.TabIndex = 8;
            // 
            // txtIRRFValue
            // 
            this.txtIRRFValue.Location = new System.Drawing.Point(156, 386);
            this.txtIRRFValue.Name = "txtIRRFValue";
            this.txtIRRFValue.ReadOnly = true;
            this.txtIRRFValue.Size = new System.Drawing.Size(100, 26);
            this.txtIRRFValue.TabIndex = 9;
            // 
            // AliquotaINSS
            // 
            this.AliquotaINSS.AutoSize = true;
            this.AliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliquotaINSS.Location = new System.Drawing.Point(85, 259);
            this.AliquotaINSS.Name = "AliquotaINSS";
            this.AliquotaINSS.Size = new System.Drawing.Size(122, 20);
            this.AliquotaINSS.TabIndex = 10;
            this.AliquotaINSS.Text = "Aliquota INSS";
            // 
            // AliquotaIRRF
            // 
            this.AliquotaIRRF.AutoSize = true;
            this.AliquotaIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliquotaIRRF.Location = new System.Drawing.Point(221, 311);
            this.AliquotaIRRF.Name = "AliquotaIRRF";
            this.AliquotaIRRF.Size = new System.Drawing.Size(123, 20);
            this.AliquotaIRRF.TabIndex = 11;
            this.AliquotaIRRF.Text = "Aliquota IRRF";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Location = new System.Drawing.Point(143, 282);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.ReadOnly = true;
            this.txtAliquotaINSS.Size = new System.Drawing.Size(100, 26);
            this.txtAliquotaINSS.TabIndex = 12;
            // 
            // txtAliquotaIRRF
            // 
            this.txtAliquotaIRRF.Location = new System.Drawing.Point(269, 334);
            this.txtAliquotaIRRF.Name = "txtAliquotaIRRF";
            this.txtAliquotaIRRF.ReadOnly = true;
            this.txtAliquotaIRRF.Size = new System.Drawing.Size(100, 26);
            this.txtAliquotaIRRF.TabIndex = 13;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 531);
            this.Controls.Add(this.txtAliquotaIRRF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.AliquotaIRRF);
            this.Controls.Add(this.AliquotaINSS);
            this.Controls.Add(this.txtIRRFValue);
            this.Controls.Add(this.txtLiquidIncomeValue);
            this.Controls.Add(this.txtINSSValue);
            this.Controls.Add(this.lbLiquidIncome);
            this.Controls.Add(this.lbIRRF);
            this.Controls.Add(this.lbINSS);
            this.Controls.Add(this.lbDesconto);
            this.Controls.Add(this.lbIncome);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.btCalc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Folha de Pagamento";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbINSS;
        private System.Windows.Forms.Label lbIRRF;
        private System.Windows.Forms.Label lbLiquidIncome;
        private System.Windows.Forms.TextBox txtINSSValue;
        private System.Windows.Forms.TextBox txtLiquidIncomeValue;
        private System.Windows.Forms.TextBox txtIRRFValue;
        private System.Windows.Forms.Label AliquotaINSS;
        private System.Windows.Forms.Label AliquotaIRRF;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaIRRF;
    }
}

