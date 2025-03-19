namespace MidtermExaminationApp
{
    public partial class Form1 : Form
    {
        decimal iphoneProMaxPrice = 69990m;
        decimal iphoneProPrice = 84990m;
        decimal iphonePlusPrice = 54990m;
        decimal iphonePrice = 62990m;
        decimal iphoneEPrice = 39990m;

        decimal appleCarePlusPrice = 2590m;
        decimal usbChargingAdapterPrice = 1990m;
        decimal magSafeChargerPrice = 2490m;
        decimal interestRate12Months = 0.05m;
        decimal interestRate24Months = 0.10m;
        decimal interestRate30Months = 0.125m;
        decimal interestRate36Months = 0.15m;

        public Form1()
        {
            InitializeComponent();
            iphonelstbox.Items.AddRange(new string[]
           {
                "iPhone 16 Pro Max (256GB)",
                "iPhone 16 Pro (128GB)",
                "iPhone 16 Plus (128GB)",
                "iPhone 16 (128GB)",
                "iPhone 16e (128GB)"
           });
            loancombobox.Items.AddRange(new string[] { "12 Months", "24 Months", "30 Months", "36 Months" });

            iphonechcklstbox.Items.AddRange(new string[]
            {
                "Apple CarePlus",
                "USB Charging Adapter",
                "Mag safe Charger(1M)"
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iphonelstbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Computebtn_Click(object sender, EventArgs e)
        {
            string selectedIphoneModel = iphonelstbox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedIphoneModel)) return;

  
            decimal principalAmount = 0m;
            if (selectedIphoneModel == "iPhone 16 Pro Max (256GB)") principalAmount = iphoneProMaxPrice;
            else if (selectedIphoneModel == "iPhone 16 Pro (128GB)") principalAmount = iphoneProPrice;
            else if (selectedIphoneModel == "iPhone 16 Plus (128GB)") principalAmount = iphonePlusPrice;
            else if (selectedIphoneModel == "iPhone 16 (128GB)") principalAmount = iphonePrice;
            else if (selectedIphoneModel == "iPhone 16e (128GB)") principalAmount = iphoneEPrice;

           
            decimal addOnsTotal = 0m;
            foreach (var item in iphonechcklstbox.CheckedItems)
            {
                if (item.ToString() == "Apple CarePlus") addOnsTotal += appleCarePlusPrice;
                else if (item.ToString() == "USB-C Charging Adapter") addOnsTotal += usbChargingAdapterPrice;
                else if (item.ToString() == "MagSafe Charger(1M)") addOnsTotal += magSafeChargerPrice;
            }

         
            principalAmount += addOnsTotal;

            string selectedLoanTerm = loancombobox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedLoanTerm)) return; 

            decimal interestRate = 0m;
            int loanTermMonths = 0;
            if (selectedLoanTerm == "12 Months")
            {
                interestRate = interestRate12Months;
                loanTermMonths = 12;
            }
            else if (selectedLoanTerm == "24 Months")
            {
                interestRate = interestRate24Months;
                loanTermMonths = 24;
            }
            else if (selectedLoanTerm == "30 Months")
            {
                interestRate = interestRate30Months;
                loanTermMonths = 30;
            }
            else if (selectedLoanTerm == "36 Months")
            {
                interestRate = interestRate36Months;
                loanTermMonths = 36;
            }

           
            decimal downPayment = principalAmount * 0.10m;
            decimal interestRateAmount = principalAmount * interestRate;
            decimal totalMonthlyAmortization = (principalAmount + interestRateAmount) / loanTermMonths;
            decimal totalAmount = principalAmount + interestRateAmount;

            label6.Text = $"Model: {selectedIphoneModel}";
            label7.Text = $"Principal Amount: Php {principalAmount:N2}";
            label9.Text = $"Loan Term: {selectedLoanTerm}";
            label11.Text = $"Interest Rate Amount: Php {interestRateAmount:N2}";

            downPaymentLabel.Text = $"Down Payment: Php {downPayment:N2}";
            label10.Text = $"Interest Rate Amount: Php {interestRateAmount:N2}";
            label12.Text = $"Monthly Amortization: Php {totalMonthlyAmortization:N2}";
            label13.Text = $"Total Amount: Php {totalAmount:N2}";
        }

        private void iphonechcklstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
