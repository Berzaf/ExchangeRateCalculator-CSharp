/*
 * Author: Berzaf Teklu
 * Programe Name: Exchange Rate Calculator
 * Date: 10/25/20
 * 
 * Create an application that the user know how many pounds he/she will have when
 * they get to England based on the number of dollars they have now and also do the 
 * reverse. calculate how many dollars they will have when in England. Do the same
 * for travelers going to Europe.
 * 
 * We need to calculate Exchange Rate of US Dolar, England Pound and Europe EURO:
 *   - From USD to EURO and USD to GBP
 *   - From EURO to USD and EURO to GBP
 *   - From GBP to USD and GBP to EURO
 * We have the input variables the amount in USD, EURO and GBP. 
 * We also have the daily convation rate.
 * 
 * Finaly to calculate the exchange rate we have to read the convartion rate values from text file.
 * Then the convertion rate :
 *    USDtoEUR = Amount * ConvertionRate(USDtoEUR)     
 *    USDtoEUR = Amount * ConvertionRate(USDtoGBP)     
 *    EURtoUSD = Amount * ConvertionRate(EURtoUSD)     
 *    EURtoGBP = Amount * ConvertionRate(EURtoGBP)     
 *    GBPtoUSD = Amount * ConvertionRate(GBPtoUSD)     
 *    GBPtoEUR = Amount * ConvertionRate(GBPtoEUR)     
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExchangeRateCalculator
{
    public partial class Form1 : Form
    {
        decimal amount;
        decimal usdToGbp;
        decimal usdToEur;
        decimal eurToUsd;
        decimal eurToGbp;
        decimal gepToUsd;
        decimal gepToEur;
        decimal usdToEurCon;
        decimal usdToGbpCon;
        decimal eurToUsdCon;
        decimal eurToGbpCon;
        decimal gepToUsdCon;
        decimal gepToEurCon;

        public Form1()
        {
            InitializeComponent();
        }


        private void ConvertButton_Click(object sender, EventArgs e)
        {
          

        

            if (decimal.TryParse(amountTextBox.Text, out amount) && amount >= 0)
            {
                try
                {
                    // A StreamReader variable 
                    StreamReader inputFile;

                    // Open the file and get a StreamReader object.
                    inputFile = File.OpenText("ConvertionRate.txt");

                    // Read the convertion rate values from the file
                    usdToEurCon = decimal.Parse(inputFile.ReadLine());
                    usdToGbpCon = decimal.Parse(inputFile.ReadLine());
                    eurToUsdCon = decimal.Parse(inputFile.ReadLine());
                    eurToGbpCon = decimal.Parse(inputFile.ReadLine());
                    gepToUsdCon = decimal.Parse(inputFile.ReadLine());
                    gepToEurCon = decimal.Parse(inputFile.ReadLine());

                    if (fromUsdRadioButton.Checked && toEurRadioButton.Checked)
                    {
                        usdToEur = decimal.Parse(amountTextBox.Text) * usdToEurCon;

                        exchangeTextBox.Text = usdToEur.ToString("n3");
                    }
                    else if (fromUsdRadioButton.Checked && toGbpRadioButton.Checked)
                    {
                        usdToGbp = decimal.Parse(amountTextBox.Text) * usdToGbpCon;

                        exchangeTextBox.Text = usdToGbp.ToString("n3");


                    }
                    else if (fromEurRadioButton.Checked && toUsdRadioButton.Checked)
                    {
                        eurToUsd = decimal.Parse(amountTextBox.Text) * eurToUsdCon;

                        exchangeTextBox.Text = eurToUsd.ToString("n3");
                    }
                    else if (fromEurRadioButton.Checked && toGbpRadioButton.Checked)
                    {
                        eurToGbp = decimal.Parse(amountTextBox.Text) * eurToGbpCon;

                        exchangeTextBox.Text = eurToGbp.ToString("n3");
                    }

                    else if (fromGbpRadioButton.Checked && toUsdRadioButton.Checked)
                    {
                        gepToUsd = decimal.Parse(amountTextBox.Text) * decimal.Parse(inputFile.ReadLine());
                        exchangeTextBox.Text = gepToUsd.ToString("n3");
                    }
                    else if (fromGbpRadioButton.Checked && toEurRadioButton.Checked)
                    {
                        gepToEur = decimal.Parse(amountTextBox.Text) * decimal.Parse(inputFile.ReadLine());
                        exchangeTextBox.Text = gepToEur.ToString("n3");
                    }

                    // close the file
                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please enter valid numbers", "Invalid Input");

            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear all
            amountTextBox.Text = "";
            exchangeTextBox.Text = "";
            amountTextBox.Focus();


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
