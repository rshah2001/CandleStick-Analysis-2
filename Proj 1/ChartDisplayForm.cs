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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proj_1
{
    // Partial class representing a form for visualizing stock data on a chart
    public partial class ChartDisplayForm : System.Windows.Forms.Form
    {
        // Private fields for internal use
        private Chart chart1;
        private BindingList<smartCandleStick> BindingCandleSticks { get; set; }
        private List<aCandleStick> templist;
        private string filename;

        // Default constructor for initializing components
        public ChartDisplayForm()
        {
            // Initialize form components
            InitializeComponent();
        }

        // Overloaded constructor to set up the form with specific data inputs
        internal ChartDisplayForm(string filename, List<aCandleStick> candlesticks, DateTimePicker start, DateTimePicker end)
        {
            // Initialize form elements
            InitializeComponent();

            // Assign values to the private fields
            templist = new List<aCandleStick>();
            templist = candlesticks;
            this.filename = filename;

            // Set initial values for the date pickers
            DateTimePicker_StartDate.Value = start.Value;
            DateTimePicker_EndDate.Value = end.Value;

            // Filter and retrieve candlestick data within the selected date range
            getCandlesticksInDateRange(start.Value, end.Value);

            // Update the chart title to match the filename without its extension
            Chart_StockData.Titles.Clear();
            Chart_StockData.Titles.Add(Path.GetFileNameWithoutExtension(filename));
            Chart_StockData.Titles[0].Font = new Font("Microsoft Sans Serif", 14.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // Bind the filtered candlesticks to the chart data source
            Chart_StockData.DataSource = BindingCandleSticks;

            // Refresh the chart bindings to display updated data
            Chart_StockData.DataBind();
        }

        // Filters the candlesticks to include only those within a specified date range
        private void getCandlesticksInDateRange(DateTime start, DateTime end)
        {
            // Initialize a new list to hold the filtered candlesticks
            BindingCandleSticks = new BindingList<smartCandleStick>();

            // Ensure the BindingCandleSticks list is empty before populating
            if (BindingCandleSticks != null)
            {
                BindingCandleSticks.Clear();
            }

            // Iterate through the list of candlesticks
            for (int i = 0; i < templist.Count; i++)
            {
                // Get the current candlestick in the list
                aCandleStick cs = templist[i];

                // Create a smart candlestick instance from the regular candlestick
                smartCandleStick scs = new smartCandleStick(cs);

                // Exit the loop if the date of the current candlestick exceeds the end date
                if (cs.date > end)
                    break;

                // Add the candlestick to the filtered list if it falls within the date range
                if (cs.date >= start)
                {
                    BindingCandleSticks.Add(scs);
                }
            }
        }

        // Event handler for the update button click event
        private void Button_Update_Click(object sender, EventArgs e)
        {
            // Ensure the BindingCandleSticks list is empty before updating
            if (BindingCandleSticks != null)
            {
                BindingCandleSticks.Clear();
            }

            // Refresh the candlestick data for the selected date range
            getCandlesticksInDateRange(DateTimePicker_StartDate.Value, DateTimePicker_EndDate.Value);

            // Reassign the filtered candlestick list as the chart's data source
            Chart_StockData.DataSource = BindingCandleSticks;

            // Update the chart to reflect the new data
            Chart_StockData.DataBind();
        }

        // Handles the action when the pattern button is clicked to annotate the chart
        private void Button_Pattern_Click(object sender, EventArgs e)
        {
            // Retrieve the selected pattern from the dropdown menu
            String selectedPattern = DropDownMenu_SelectPattern.SelectedItem.ToString();

            // Remove any existing annotations on the chart
            Chart_StockData.Annotations.Clear();

            // Iterate through each candlestick in the filtered list
            foreach (smartCandleStick scs in BindingCandleSticks)
            {
                // Depending on the selected pattern, add annotations to the chart
                switch (selectedPattern)
                {
                    case "Bullish":
                        if (scs.isBullish)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Bullish");
                        }
                        break;

                    case "Bearish":
                        if (scs.isBearish)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Bearish");
                        }
                        break;

                    case "Neutral":
                        if (scs.isNeutral)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Neutral");
                        }
                        break;

                    case "Marubozu":
                        if (scs.isMarubozu)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Marubozu");
                        }
                        break;

                    case "Doji":
                        if (scs.isDoji)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Doji");
                        }
                        break;

                    case "DragonFlyDoji":
                        if (scs.isDragonFlyDoji)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "DragonFlyDoji");
                        }
                        break;

                    case "GravestoneDoji":
                        if (scs.isGraveStoneDoji)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "GravestoneDoji");
                        }
                        break;

                    case "Hammer":
                        if (scs.isHammer)
                        {
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Hammer");
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        // Adds an arrow annotation to highlight a specific pattern on the chart
        private void ArrowAnnotationFunc(int ind, String str)
        {
            // Create a new arrow annotation object
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrow = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();

            // Retrieve the data point at the specified index from the chart series
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint = Chart_StockData.Series["series_OHLC"].Points[ind];

            // Set properties for the arrow annotation
            arrow.ClipToChartArea = "area_OHLC";
            arrow.AxisX = Chart_StockData.ChartAreas["area_OHLC"].AxisX;
            arrow.AxisY = Chart_StockData.ChartAreas["area_OHLC"].AxisY;
            arrow.AnchorDataPoint = dataPoint;
            arrow.LineColor = Color.Black;
            arrow.ForeColor = Color.Black;
            arrow.BackColor = Color.Black;
            arrow.BackSecondaryColor = Color.Black;
            arrow.ShadowColor = Color.Transparent;
            arrow.Height = -7;
            arrow.Width = .2;
            arrow.LineWidth = 1;
            arrow.Alignment = ContentAlignment.TopLeft;

            // Configure additional properties for the arrow annotation
            arrow.AxisY.IsStartedFromZero = false;
            arrow.IsSizeAlwaysRelative = true;

            // Add the arrow annotation to the chart's collection of annotations
            Chart_StockData.Annotations.Add(arrow);
        }

        private void Chart_StockData_Click(object sender, EventArgs e)
        {

        }

        private void Label_UpdateEndDate_Click(object sender, EventArgs e)
        {

        }
    }
}
