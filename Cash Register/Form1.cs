//Kiril Covaliov
//Mr. Theodoreopolous ICS3U
//2.11.21
//Cash Register Summative Assignment


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace Cash_Register
{
    public partial class backround : Form
    {   //Global Variables
        int computer = 750;
        int television = 500;
        int smartphone = 635;
        int computerNumber;
        int televisionNumber;
        int smartphoneNumber;
        double taxAmount;
        double tax = 0.13;
        double subtotal;
        double totalcost;
        double change;
        double tendered;
        
        SoundPlayer player = new SoundPlayer(Properties.Resources._345056__azumarill__epson_receipt_printer3); //Audio

        public backround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                computerNumber = Convert.ToInt32(computerText.Text); // amount of computers entered in computer textbox
                televisionNumber = Convert.ToInt32(tvText.Text);     // amount of televisions entered in television textbox
                smartphoneNumber = Convert.ToInt32(phoneText.Text);  // amount of smartphones entered in smartphone textbox
                subtotal = computer * computerNumber + television * televisionNumber + smartphone * smartphoneNumber; //subtotal calculations
                subtotalOutput.Text = $"{subtotal.ToString("C")}";  //subtotal display
                taxAmount = subtotal * tax;                         //tax amount calculations
                taxOutput.Text = $"{taxAmount.ToString("C")}";      //tax amount display
                totalcost = taxAmount + subtotal;                   //total cost calculations
                totalOutput.Text = $"{totalcost.ToString("C")}";    //total cost display

            }

            catch
            {
                errorOutput.Text += "Please enter a proper amount above."; //error message pops up if improper amount of products is entered 
            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt32(tenderedText.Text); //tendered amount entered into tendered textbox
                change = tendered - totalcost;                 //change calculations
                changeOutput.Text = $"{change.ToString("C")}"; //change display
            }

            catch
            {
                changeErrorOutput.Text = "Please enter a proper amount above."; //error message pops up if improper amount of tendered currency is entered 
            }
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {   
            
            player.Play(); //Audio
            //Receipt text
            receiptOutput.Text = " BestBought";
            Refresh();
            Thread.Sleep(380);

            receiptOutput.Text += "\n\n Order number: 735274910";
            Refresh();
            Thread.Sleep(380);

            receiptOutput.Text += "\n Date of Purchase: February 11 2021";
            Refresh();
            Thread.Sleep(380);

            receiptOutput.Text += $"\n\n Computers   $750 x {computerNumber}";
            Refresh();
            Thread.Sleep(380);
            receiptOutput.Text += $"\n Television     $500 x {televisionNumber}";
            Refresh();
            Thread.Sleep(380);
            receiptOutput.Text += $"\n SmartPhone $635 x {smartphoneNumber}";
            Refresh();
            Thread.Sleep(380);

            receiptOutput.Text += $"\n\n Subtotal: {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(380);
            receiptOutput.Text += $"\n Tax:         {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(380);
            receiptOutput.Text += $"\n Total:       {totalcost.ToString("C")}";
            Refresh();
            Thread.Sleep(380);

            receiptOutput.Text += $"\n\n Tendered: {tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(380);
            receiptOutput.Text += $"\n Change:   {change.ToString("C")}";
            Refresh();
            Thread.Sleep(500);

            receiptOutput.Text += "\n\n\n Thank you for your purchase at BestBought, we look forward to your next visit!";


        }

        private void NeworderButton_Click(object sender, EventArgs e)
        {   //New Order button reseting everyting below to $00.00 or nothing at all.
            receiptOutput.Text = "";
            computerText.Text = "";
            tvText.Text = "";
            phoneText.Text = "";
            subtotalOutput.Text = "$00.00";
            taxOutput.Text = "$00.00";
            totalOutput.Text = "$00.00";
            tenderedText.Text = "";
            changeOutput.Text = "$00.00";
        }

        private void SubtotalOutput_Click(object sender, EventArgs e)
        {

        }

        private void ErrorOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
