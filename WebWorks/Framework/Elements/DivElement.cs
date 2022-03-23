using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebWorks.Framework.Objects;

namespace WebWorks.Framework.Elements
{
    /// <summary>
    /// Defines a division
    /// </summary>
    public class DivElement : Element
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public DivElement(Element parent)
        {
            if(WebWorksModule.CodeConstructor == null) {   throw new Exception("The code constructor within the main WebWorks module is null");   }

            if(parent != null)
            {
                parent.Children.Add(this);
            }
            else
            {
                throw new Exception("Cannot assign to a parent that is null");
            }
        }
    }
}
