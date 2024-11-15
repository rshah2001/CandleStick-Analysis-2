/*
Name: Rishil Shah
UNumber: U69116245
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_1
{
    // A partial class named FormEntry that inherits from the Form class
    public partial class FormEntry : Form
    {
        // A string representing the header format for the input file
        private static String referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

        // Constructor for initializing the FormEntry class
        public FormEntry()
        {
            // Initialize the form's components
            InitializeComponent();
        }

        // Event handler for the file dialog when a file is selected
        private void LoadButtonOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Load candlesticks from the selected files and open chart display forms
            List<List<aCandleStick>> allCandlesticks = loadCandlesticks(LoadButtonOpenFileDialog.FileNames);
            openDisplayChartForms(LoadButtonOpenFileDialog.FileNames, allCandlesticks);
        }

        // Method to convert the array of filenames to a list and invoke the main loading function
        private List<List<aCandleStick>> loadCandlesticks(string[] arrayofFilenames)
        {
            List<string> listofFilenames = arrayofFilenames.ToList<string>();
            return loadCandlesticks(listofFilenames);
        }

        // Main method to load candlesticks from a list of filenames
        private List<List<aCandleStick>> loadCandlesticks(List<string> listofFilenames)
        {
            // A list to hold the loaded candlesticks
            List<List<aCandleStick>> resultingList = new List<List<aCandleStick>>(listofFilenames.Count());

            // Iterate over each filename and load the candlesticks
            foreach (string filename in listofFilenames)
            {
                List<aCandleStick> candlesticks = loadStockFromFile(filename);
                resultingList.Add(candlesticks);
            }

            return resultingList;
        }

        // Method to load candlesticks from a specific stock data file
        private List<aCandleStick> loadStockFromFile(string filename)
        {
            List<aCandleStick> templist = new List<aCandleStick>(1024);

            // Open the file for reading
            using (StreamReader sr = new StreamReader(filename))
            {
                string header = sr.ReadLine();
                string[] columns = header.Replace("\"", "").Split(',');

                // Get the indices for the columns from the header
                int dateIndex = Array.IndexOf(columns, "Date");
                int openIndex = Array.IndexOf(columns, "Open");
                int highIndex = Array.IndexOf(columns, "High");
                int lowIndex = Array.IndexOf(columns, "Low");
                int closeIndex = Array.IndexOf(columns, "Close");
                int volumeIndex = Array.IndexOf(columns, "Volume");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Create a new candlestick object for each line of data
                    aCandleStick cs = new aCandleStick(line, dateIndex, openIndex, highIndex, lowIndex, closeIndex, volumeIndex);
                    templist.Add(cs);
                }

                // Reverse the list to have the correct order (older data first)
                templist.Reverse();
            }

            return templist;
        }

        // Method to open a new chart display form for each loaded file
        private void openDisplayChartForms(string[] arrayofFilenames, List<List<aCandleStick>> allCandlesticks)
        {
            // Iterate through each file and open a new chart form
            for (int i = 0; i < arrayofFilenames.Length; i++)
            {
                ChartDisplayForm newForm = new ChartDisplayForm(arrayofFilenames[i], allCandlesticks[i], DateTimePicker_StartDate, DateTimePicker_EndDate);
                newForm.Show();
            }
        }

        // Event handler for the "Load" button click event, shows the file dialog
        private void button_Load_Click(object sender, EventArgs e)
        {
            LoadButtonOpenFileDialog.ShowDialog();
        }

        // Event handler for when the Start Date label is clicked (currently empty)
        private void StartDateLabel_Click(object sender, EventArgs e)
        {

        }

        // Event handler for when the FormEntry is loaded
        private void FormEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
