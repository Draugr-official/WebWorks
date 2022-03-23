using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebWorks.Framework.Objects
{
    /// <summary>
    /// Data segment being used when assigning properties to elements
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Defines the value of the data
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Defines the type of the data
        /// </summary>
        public DataType Type { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        public Data(double value, DataType type)
        {
            Value = value;
            Type = type;
        }
    }

    /// <summary>
    /// A set of datatypes being used when assigning 
    /// </summary>
    public enum DataType
    {
        Percent,
        Pixel
    }
}
