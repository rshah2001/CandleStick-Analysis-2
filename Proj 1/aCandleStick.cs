/*
Name: Rishil Shah
UNumber: U69116245
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    // Class that represents a financial candlestick with its essential data like open, high, low, close prices, volume, and date
    internal class aCandleStick
    {
        // Properties that represent the individual components of a candlestick
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }
        public DateTime date { get; set; }

        // Constructor for initializing a new instance of aCandleStick with the given parameters
        public aCandleStick(DateTime date = default, decimal open = 0, decimal high = 0, decimal low = 0, decimal close = 0, long volume = 0)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }

        // Constructor to initialize aCandleStick from a string containing raw data
        public aCandleStick(String rowofData, int dateIndex, int openIndex, int highIndex, int lowIndex, int closeIndex, int volumeIndex)
            : this() // Calls the default constructor to initialize default values first
        {
            // Split the raw data row by commas after removing any quotation marks
            string[] subs = rowofData.Replace("\"", "").Split(',');

            DateTime tempDate;
            decimal temp;
            long tempVolume;

            // Try parsing the date from the string data and assign it to the date property
            if (DateTime.TryParse(subs[dateIndex], out tempDate))
                date = tempDate;

            // Try parsing the open price and assign it to the open property
            if (Decimal.TryParse(subs[openIndex], out temp))
                open = temp;

            // Try parsing the high price and assign it to the high property
            if (Decimal.TryParse(subs[highIndex], out temp))
                high = temp;

            // Try parsing the low price and assign it to the low property
            if (Decimal.TryParse(subs[lowIndex], out temp))
                low = temp;

            // Try parsing the close price and assign it to the close property
            if (Decimal.TryParse(subs[closeIndex], out temp))
                close = temp;

            // Try parsing the volume and assign it to the volume property
            if (long.TryParse(subs[volumeIndex], out tempVolume))
                volume = tempVolume;
        }
    }
}
