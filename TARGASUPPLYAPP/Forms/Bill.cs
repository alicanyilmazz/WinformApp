using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;
using TARGASUPPLYAPP.Components;
using System.Threading;

namespace TARGASUPPLYAPP.Forms
{
    public partial class Bill : Form
    {

        int selectedTaxRate = 1;
        double taxCost = 0;
        double price = 0;
        double quantityPrice = 0;
        int quantityOfProduct = 0;
        Regex moneyCheck = new Regex(@"^\$?([0-9]{1,3}.([0-9]{3}.)*[0-9]{3}|[0-9]+)(\,[0-9][0-9])?$");
        Regex onlyNumberCheck = new Regex(@"^([a-z0-9]*[a-z]){3}[a-z0-9]*$");
        Regex emptyCheck = new Regex(@"(?!^$)([^\s])");
        //Regex emptyCheck = new Regex(@"^(\w+\S+)$");
        List<String> warning_messages = new List<string>();
        static List<RichTextStatus> richTextStatusList;
        static string nameEmptyWarning = " Müşteri ad soyad bilgisi boş olamaz. \n";
        static string adressEmptyWarning = " Müşteri Adres bilgisi boş olamaz. \n";
        static string clockEmptyWarning = " Fatura saat bilgisi boş olamaz. \n";
        static string productNameEmptyWarning = " Ürün Ad bilgisi boş olamaz. \n";
        static string quantityEmptyWarning = " Ürün adet bilgisi boş olamaz. \n";
        static string quantityNumberFormatWarning = " Ürün adet bilgisi rakam dışında bilgi içeremez. \n";//Bu
        static string priceEmptyWarning = " Fiyat bilgisi boş olamaz. \n";
        static string priceFormatWarning = " Fiyat formatı yanlış. \n"; //bu
        static string priceHWEmptyWarning = " Fiyat yazı bilgisi boş olamaz. \n";
        List<string> nameOfBookMarks = new List<string>()
            {
                "CustomerName",
                "Adress",
                "Date",
                "Clock",
                "ProductName",
                "Quantity",
                "Price",
                "QuantityPrice",
                "SubQuantityPrice",
                "TaxRate",
                "Tax",
                "TotalCost",
                "TotalCostText",
                "Date2",

            };
        public Bill()
        {
            InitializeComponent();

            richTextStatusList = new List<RichTextStatus>()
            {
            new RichTextStatus(txtName, false, false, nameEmptyWarning),
            new RichTextStatus(txtBillingAdress, false, false, adressEmptyWarning),
            new RichTextStatus(txtBillClock, false, false, clockEmptyWarning),
            new RichTextStatus(txtProductName, false, false, productNameEmptyWarning),
            new RichTextStatus(txtQuantity, false, false, quantityEmptyWarning,false,false,quantityNumberFormatWarning),
            new RichTextStatus(txtPrice, false, false, priceEmptyWarning,false,false,priceFormatWarning),
            new RichTextStatus(txtAllCostHW, false, false, priceHWEmptyWarning)
           };
            loadTheme();
        }

        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labelName.ForeColor = ThemeColor.SecondaryColor;
            labelAdress.ForeColor = ThemeColor.SecondaryColor;
            labelDate.ForeColor = ThemeColor.SecondaryColor;
            labelClock.ForeColor = ThemeColor.SecondaryColor;
            labelProductName.ForeColor = ThemeColor.SecondaryColor;
            labelNumberofProduct.ForeColor = ThemeColor.SecondaryColor;
            labelProductPrice.ForeColor = ThemeColor.SecondaryColor;
            labelTax.ForeColor = ThemeColor.SecondaryColor;
            labelHW.ForeColor = ThemeColor.SecondaryColor;
            downPanel.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedTaxRate = 18;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {

            if (emptyCheckFluentValidation(richTextStatusList) && moneyFormatCheckValidation(richTextStatusList[5]))
            {

                CreateFile();

            }
            else
            {
                Alert alerts;
                foreach (var item in warning_messages)
                {
                    alerts = new Alert();
                    alerts.showAlert(item, Alert.enmType.Warning);
                }
            }
        }


        private void CreateFile()
        {
            Application app = new Application();
            app.Visible = false;
            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(Directory.GetCurrentDirectory() + "\\main.docx");
            bookmarkCreator(nameOfBookMarks, doc);

            doc.Save();
            doc.Close();

            fileCopy();

            Alert validationAlert = new Alert();
            validationAlert.showAlert("Faturayı yazdırabilirsiniz.", Alert.enmType.Success);

        }

        private void bookmarkCreator(List<string> nameOfBookMarks, Microsoft.Office.Interop.Word.Document doc)
        {
            //Customer Name
            Bookmark bookmarkName = doc.Bookmarks[nameOfBookMarks[0]];
            Range rangeName = bookmarkName.Range;
            rangeName.Text = txtName.Text;
            doc.Bookmarks.Add(nameOfBookMarks[0], rangeName);

            //Adress
            Bookmark bookmarkAdress = doc.Bookmarks[nameOfBookMarks[1]];
            Range rangeAdress = bookmarkAdress.Range;
            rangeAdress.Text = txtBillingAdress.Text;
            doc.Bookmarks.Add(nameOfBookMarks[1], rangeAdress);

            //Date
            Bookmark bookmarkDate = doc.Bookmarks[nameOfBookMarks[2]];
            Range rangeDate = bookmarkDate.Range;
            rangeDate.Text = txtBillDate.Value.ToString("dd/MM/yyyy");
            doc.Bookmarks.Add(nameOfBookMarks[2], rangeDate);

            //Clock
            Bookmark bookmarkClock = doc.Bookmarks[nameOfBookMarks[3]];
            Range rangeClock = bookmarkClock.Range;
            rangeClock.Text = txtBillClock.Text;
            doc.Bookmarks.Add(nameOfBookMarks[3], rangeClock);

            //ProductName
            Bookmark bookmarkProductName = doc.Bookmarks[nameOfBookMarks[4]];
            Range rangeProductName = bookmarkProductName.Range;
            rangeProductName.Text = txtProductName.Text;
            doc.Bookmarks.Add(nameOfBookMarks[4], rangeProductName);

            //Quantity
            Bookmark bookmarkQuantity = doc.Bookmarks[nameOfBookMarks[5]];
            Range rangeQuantity = bookmarkQuantity.Range;
            rangeQuantity.Text = txtQuantity.Text;
            doc.Bookmarks.Add(nameOfBookMarks[5], rangeQuantity);

            //Price
            Bookmark bookmarkPrice = doc.Bookmarks[nameOfBookMarks[6]];
            Range rangePrice = bookmarkPrice.Range;
            rangePrice.Text = calculateUnitNetPrice().ToString("0.##") + "  "; //Method1
            doc.Bookmarks.Add(nameOfBookMarks[6], rangePrice);

            //QuantityPrice
            Bookmark bookmarkQuantityPrice = doc.Bookmarks[nameOfBookMarks[7]];
            Range rangeQuantityPrice = bookmarkQuantityPrice.Range;
            rangeQuantityPrice.Text = calculateQuantityNetPrice().ToString("0.##") + "  "; //Method1
            doc.Bookmarks.Add(nameOfBookMarks[7], rangeQuantityPrice);

            //SubQuantityPrice
            Bookmark bookmarkSubQuantityPrice = doc.Bookmarks[nameOfBookMarks[8]];
            Range rangeSubQuantityPrice = bookmarkSubQuantityPrice.Range;
            rangeSubQuantityPrice.Text = calculateQuantityNetPrice().ToString("0.##") + "  "; //Method1
            doc.Bookmarks.Add(nameOfBookMarks[8], rangeSubQuantityPrice);

            //TaxRate
            Bookmark bookmarkTaxRate = doc.Bookmarks[nameOfBookMarks[9]];
            Range rangeTaxRate = bookmarkTaxRate.Range;
            rangeTaxRate.Text = selectedTaxRate.ToString();
            doc.Bookmarks.Add(nameOfBookMarks[9], rangeTaxRate);


            //Tax
            Bookmark bookmarkTax = doc.Bookmarks[nameOfBookMarks[10]];
            Range rangeTax = bookmarkTax.Range;
            rangeTax.Text = calculateTax().ToString("0.##") + "  "; //Method2
            doc.Bookmarks.Add(nameOfBookMarks[10], rangeTax);

            //TotalCost
            Bookmark bookmarkTotalCost = doc.Bookmarks[nameOfBookMarks[11]];
            Range rangeTotalCost = bookmarkTotalCost.Range;
            rangeTotalCost.Text = calculateTotalPrice().ToString() + " ";
            doc.Bookmarks.Add(nameOfBookMarks[11], rangeTotalCost);

            //TotalCostHW
            Bookmark bookmarkTotalCostHW = doc.Bookmarks[nameOfBookMarks[12]];
            Range rangeTotalCostHW = bookmarkTotalCostHW.Range;
            rangeTotalCostHW.Text = txtAllCostHW.Text + " ";
            doc.Bookmarks.Add(nameOfBookMarks[12], rangeTotalCostHW);

            //Date2
            Bookmark bookmarkDate2 = doc.Bookmarks[nameOfBookMarks[13]];
            Range rangeDate2 = bookmarkDate2.Range;
            rangeDate2.Text = txtBillDate.Value.ToString("MM/dd/yyyy");
            doc.Bookmarks.Add(nameOfBookMarks[13], rangeDate2);
        }

        private double calculateTax()
        {
            double grossPrice = ((double)Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text));
            return ((double)grossPrice - calculateQuantityNetPrice());
        }

        private double calculateUnitNetPrice()
        {
            double unitGrossPrice = (Convert.ToDouble(txtPrice.Text));
            double formula = (1 + (((double)selectedTaxRate / 100)));
            double result = (unitGrossPrice / formula);
            return result;
        }
        private double calculateQuantityNetPrice()
        {
            double allGrossPrice = (Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text));
            double formula = (1 + (((double)selectedTaxRate / 100)));
            double result = ((double)allGrossPrice / formula);
            return result;
        }

        private double calculateTotalPrice()
        {
            double result = ((double)(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuantity.Text)));
            return result;
        }

        private bool emptyCheckValidation(List<RichTextStatus> listRichText)
        {
            bool result = true;
            foreach (var richText in listRichText)
            {
                if (!RegexControl(emptyCheck, richText))
                {
                    if (richText.textAdded == false)
                    {
                        warning_messages.Add(richText.errorMessage);
                        richText.textAdded = true;
                    }

                    richText.error = true;
                }
                else
                {
                    if (richText.textAdded == true)
                    {
                        warning_messages.Remove(richText.errorMessage);
                        richText.textAdded = false;
                    }

                    richText.error = false;
                }
            }


            foreach (var richText in listRichText)
            {
                if (richText.error == true)
                {
                    result = false;
                }
            }

            return result;

        }

        private bool emptyCheckFluentValidation(List<RichTextStatus> listRichText)
        {
            bool result = true;
            foreach (var richText in listRichText)
            {
                if (!emptyFluentCheck(richText))
                {
                    if (richText.textAdded == false)
                    {
                        warning_messages.Add(richText.errorMessage);
                        richText.textAdded = true;
                    }

                    richText.error = true;
                }
                else
                {
                    if (richText.textAdded == true)
                    {
                        warning_messages.Remove(richText.errorMessage);
                        richText.textAdded = false;
                    }

                    richText.error = false;
                }
            }


            foreach (var richText in listRichText)
            {
                if (richText.error == true)
                {
                    result = false;
                }
            }

            return result;

        }

        private bool emptyFluentCheck(RichTextStatus richText)
        {
            if ((String.IsNullOrEmpty((richText.textBox.Text))))
            {
                return false;
            }

            return true;
        }

        private bool moneyFormatCheckValidation(RichTextStatus richText)
        {
            bool result = true;

            if (!RegexControl(moneyCheck, richText))
            {
                if (richText.secondTextAdded == false)
                {
                    warning_messages.Add(richText.secondErrorMessage);
                    richText.secondTextAdded = true;
                }

                richText.secondError = true;
            }
            else
            {
                if (richText.secondTextAdded == true)
                {
                    warning_messages.Remove(richText.secondErrorMessage);
                    richText.secondTextAdded = false;
                }

                richText.secondError = false;
            }

            if (richText.secondError == true)
            {
                result = false;
            }

            return result;

        }

        private bool quantityNumberFormatCheckValidation(RichTextStatus richText)
        {
            bool result = true;

            if (!RegexControl(onlyNumberCheck, richText))
            {
                if (richText.secondTextAdded == false)
                {
                    warning_messages.Add(richText.secondErrorMessage);
                    richText.secondTextAdded = true;
                }

                richText.secondError = true;
            }
            else
            {
                if (richText.secondTextAdded == true)
                {
                    warning_messages.Remove(richText.secondErrorMessage);
                    richText.secondTextAdded = false;
                }

                richText.secondError = false;
            }

            if (richText.secondError == true)
            {
                result = false;
            }

            return result;

        }

        bool RegexControl(Regex regex, RichTextStatus textboxStatus)
        {
            return regex.IsMatch(textboxStatus.textBox.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedTaxRate = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedTaxRate = 8;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillClock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAllCostHW_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void fileCopy()
        {
            System.IO.File.Copy("main.docx", $"{Guid.NewGuid()}.docx", true);
            Alert alerts = new Alert();
            alerts.showAlert("Dosya oluşturuldu.", Alert.enmType.Info);
        }



        private void txtBillDate_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
