using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWorks.Framework.Elements;

namespace WebWorks.Framework
{
    /// <summary>
    /// Markup constructor for segmenting all created components
    /// </summary>
    public class Constructor
    {
        /// <summary>
        /// Builder for sewing all parts together
        /// </summary>
        StringBuilder MarkupBuilder { get; set; }

        /// <summary>
        /// The primary webworks module being utilized
        /// </summary>
        WebWorksModule Module { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public Constructor(WebWorksModule module)
        {
            MarkupBuilder = new StringBuilder();
            Module = module;
        }

        /// <summary>
        /// Generates the code representation of the element inputted
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool GenerateElement(Element element)
        {
            if(element is DivElement div)
            {
                MarkupBuilder.Append("<div>");
                GenerateElements(div.Children);
                MarkupBuilder.Append("</div>");
                return true;
            }

            return false;
        }

        /// <summary>
        /// Generates the code representation of all elements inputted
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public bool GenerateElements(List<Element> elements)
        {
            foreach (Element element in elements)
            {
                if (!GenerateElement(element))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Generates the code representation of all elements and puts it in MarkupBuilder
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string GenerateCode()
        {
            foreach (Element element in Module.MarkupBase.Children)
            {
                if(!GenerateElement(element))
                {
                    throw new Exception($"Element '{element}' not supported");
                }
            }

            return MarkupBuilder.ToString();
        }
    }
}
