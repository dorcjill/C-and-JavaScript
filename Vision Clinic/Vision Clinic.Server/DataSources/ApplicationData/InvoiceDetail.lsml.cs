using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class InvoiceDetail
    {
        partial void Product_Changed()
        {
            UnitPrice = Product.CurrentPrice;

            Quantity = 1;
        }

        partial void SubTotal_Compute(ref decimal result)
        {
            result = Quantity * UnitPrice;
        }
    }
}
