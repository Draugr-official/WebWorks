using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWorks.Framework.Elements;

namespace WebWorks.Framework
{
    /// <summary>
    /// The main webworks module
    /// </summary>
    public class WebWorksModule
    {
        /// <summary>
        /// The current active code constructor being used
        /// </summary>
        public static Constructor CodeConstructor { get; set; }

        /// <summary>
        /// Defines the identifier for which elements should be generated
        /// </summary>
        public HtmlElement MarkupBase { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public WebWorksModule()
        {
            CodeConstructor = new Constructor(this);
            MarkupBase = new HtmlElement();
        }
    }
}
