using System;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            double income = double.Parse(txtIncome.Text);
            double aliquotaINSS = 0;
            double descINSS = 0;
            double aliquotaIRRF = 0;
            double descIRRF = 0;

            calcINSS(income, aliquotaINSS, descINSS);
            calcIRRF(income, aliquotaIRRF, descINSS, descIRRF);
            calcLiquidIncome(income);
        }

        private void calcLiquidIncome(double income)
        {
            double offINSS = double.Parse(txtINSSValue.Text);
            double offIRRF = double.Parse(txtIRRFValue.Text);
            double liquidIncome = income - offINSS - offIRRF;
            txtLiquidIncomeValue.Text = liquidIncome.ToString("F");
        }

        private void calcINSS(double income, double aliquotaINSS, double descINSS)
        {
            double aliquotaPorcentagem;

            if (income <= 1100)
            {
                aliquotaINSS = 0.075;
                aliquotaPorcentagem = aliquotaINSS * 100;
                txtAliquotaINSS.Text = aliquotaPorcentagem.ToString() + '%';

                descINSS = income * aliquotaINSS;
                txtINSSValue.Text = descINSS.ToString("F");
            }
            else if (income >= 1100.01 & income <= 2203.48)
            {
                aliquotaINSS = 0.09;
                aliquotaPorcentagem = aliquotaINSS * 100;
                txtAliquotaINSS.Text = aliquotaPorcentagem.ToString() + '%';

                descINSS = (1100 * 0.075) + (income - 1100) * aliquotaINSS;
                txtINSSValue.Text = descINSS.ToString("F");
            }
            else if (income >= 2203.49 & income <= 3305.22)
            {
                aliquotaINSS = 0.12;
                aliquotaPorcentagem = aliquotaINSS * 100;
                txtAliquotaINSS.Text = aliquotaPorcentagem.ToString() + '%';

                descINSS = (1100 * 0.075) + ((2203.48 - 1100) * 0.09) + ((income - 2203.48) * aliquotaINSS);
                txtINSSValue.Text = descINSS.ToString("F");
            }
            else if (income >= 3305.23 & income <= 6433.57)
            {
                aliquotaINSS = 0.14;
                aliquotaPorcentagem = aliquotaINSS * 100;
                txtAliquotaINSS.Text = aliquotaPorcentagem.ToString() + '%';

                descINSS = (1100 * 0.075) + ((2203.48 - 1100) * 0.09) + ((3305.22 - 2203.48) * 0.12) + ((income - 3305.22) * aliquotaINSS);
                txtINSSValue.Text = descINSS.ToString("F");
            }
        }

        private void calcIRRF(double income, double aliquotaIRRF, double descINSS, double descIRRF)
        {
            double aliquotaPorcentagem;
            descINSS = double.Parse(txtINSSValue.Text);
            income -= descINSS;

            if (income <= 1903.98)
            {
                aliquotaIRRF = 0;
                txtAliquotaIRRF.Text = aliquotaIRRF.ToString() + '%';

                double ded = 0;
                descIRRF = (income * aliquotaIRRF) - ded;
                txtIRRFValue.Text = descIRRF.ToString("F");

            }
            else if (income >= 1903.99 & income <= 2826.66)
            {
                aliquotaIRRF = 0.075;
                aliquotaPorcentagem = aliquotaIRRF * 100;
                txtAliquotaIRRF.Text = aliquotaPorcentagem.ToString() + '%';

                double ded = 142.80;
                descIRRF = (income * aliquotaIRRF) - ded;
                txtIRRFValue.Text = descIRRF.ToString("F");
            }
            else if (income >= 2826.67 & income <= 3751.05)
            {
                aliquotaIRRF = 0.15;
                aliquotaPorcentagem = aliquotaIRRF * 100;
                txtAliquotaIRRF.Text = aliquotaPorcentagem.ToString() + '%';

                double ded = 354.80;
                descIRRF = (income * aliquotaIRRF) - ded;
                txtIRRFValue.Text = descIRRF.ToString("F");
            }
            else if (income >= 3751.06 & income <= 4664.68)
            {
                aliquotaIRRF = 0.22;
                aliquotaPorcentagem = aliquotaIRRF * 100;
                txtAliquotaIRRF.Text = aliquotaPorcentagem.ToString("") + '%';

                double ded = 636.13;
                descIRRF = (income * aliquotaIRRF) - ded;
                txtIRRFValue.Text = descIRRF.ToString("F");
            }
            else if (income >= 4664.69)
            {
                aliquotaIRRF = 0.275;
                aliquotaPorcentagem = aliquotaIRRF * 100;
                txtAliquotaIRRF.Text = aliquotaPorcentagem.ToString() + '%';

                double ded = 869.36;
                descIRRF = (income * aliquotaIRRF) - ded;
                txtIRRFValue.Text = descIRRF.ToString("F");
            };
        }
    }
}