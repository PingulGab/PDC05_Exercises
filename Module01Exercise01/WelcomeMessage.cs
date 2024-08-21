using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Exercise01
{
    public class WelcomeMessage : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"Welcome! \nToday is:" + DateTime.Now.ToString("MMMM, dd, yyyy");
        }
    }
}
