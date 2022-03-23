using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWorks.Framework.Objects;

namespace WebWorks.Framework.Elements
{
    /// <summary>
    /// Framework element superklasse
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Defines the width of the element
        /// </summary>
        public Data Width { get; set; }

        /// <summary>
        /// Defines the height of the element
        /// </summary>
        public Data Height { get; set; }

        /// <summary>
        /// Defines the children within the element
        /// </summary>
        public List<Element> Children { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Element()
        {
            Width = new Data(50, DataType.Pixel);
            Height = new Data(50, DataType.Pixel);
            Children = new List<Element>();
        }
    }
}
