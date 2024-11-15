/*
Name: Rishil Shah
UNumber: U69116245
*/

// Importing required namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

// Defining the namespace for the project
namespace Proj_1
{
    // Class definition for smartCandleStick, which extends the aCandleStick class
    internal class smartCandleStick : aCandleStick
    {
        // Public properties to store additional candlestick data
        public Decimal range { get; set; }
        public Decimal bodyRange { get; set; }
        public Decimal topPrice { get; set; }
        public Decimal bottomPrice { get; set; }
        public Decimal topTail { get; set; }
        public Decimal bottomTail { get; set; }
        public Boolean isBullish { get; set; }
        public Boolean isBearish { get; set; }
        public Boolean isNeutral { get; set; }
        public Boolean isMarubozu { get; set; }
        public Boolean isDoji { get; set; }
        public Boolean isDragonFlyDoji { get; set; }
        public Boolean isGraveStoneDoji { get; set; }
        public Boolean isHammer { get; set; }

        // Static variable used for calculating Doji patterns
        static Decimal dojiBuffer = 0.05M;

        // Constructor that initializes the smartCandleStick from an existing aCandleStick
        public smartCandleStick(aCandleStick cs)
        {
            this.volume = cs.volume;
            this.open = cs.open;
            this.close = cs.close;
            this.high = cs.high;
            this.low = cs.low;
            this.date = cs.date;

            // Compute higher-level properties and pattern checks
            computeHigherProperties();
            computePatterns();
        }

        // Method to compute additional candlestick properties such as range, body range, etc.
        void computeHigherProperties()
        {
            range = high - low;
            bodyRange = Math.Abs(open - close);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            topTail = Math.Max(high - topPrice, 0);
            bottomTail = Math.Max(bottomPrice - low, 0);
        }

        // Method to compute various candlestick patterns
        void computePatterns()
        {
            isBullish = isBullishcs();
            isBearish = isBearishcs();
            isNeutral = isNeutralcs();
            isMarubozu = isMarubozucs();
            isHammer = isHammercs();
            isDoji = isDojics();
            isDragonFlyDoji = isDragonFlyDojics();
            isGraveStoneDoji = isGraveStoneDojics();
        }

        // Checks if the candlestick represents a bullish pattern
        Boolean isBullishcs()
        {
            return open < close;
        }

        // Checks if the candlestick represents a neutral pattern
        Boolean isNeutralcs()
        {
            return (bodyRange <= 0.5M * range) && (topTail <= 0.1M * range) && (bottomTail <= 0.1M * range);
        }

        // Checks if the candlestick represents a bearish pattern
        Boolean isBearishcs()
        {
            return open > close;
        }

        // Checks if the candlestick is a Marubozu (no wick, body covers entire range)
        Boolean isMarubozucs()
        {
            return bodyRange == range;
        }

        // Checks if the candlestick is a Doji (very small body compared to the range)
        Boolean isDojics()
        {
            return bodyRange < dojiBuffer * open;
        }

        // Checks if the candlestick is a Hammer (small body, long lower wick)
        Boolean isHammercs()
        {
            return topTail < 0.03M * range && bodyRange >= 0.2M * range && bodyRange <= 0.3M * range;
        }

        // Checks if the candlestick is a Dragonfly Doji (Doji with a long lower wick)
        Boolean isDragonFlyDojics()
        {
            return (bodyRange < 0.1M * range) && (bottomTail <= 0.1M * range) && (topTail >= 2 * bottomTail);
        }

        // Checks if the candlestick is a Gravestone Doji (Doji with a long upper wick)
        Boolean isGraveStoneDojics()
        {
            return (bodyRange < 0.1M * range) && (topTail <= 0.1M * range) && (bottomTail >= 2 * topTail);
        }
    }
}
