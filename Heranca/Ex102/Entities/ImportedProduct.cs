using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex102.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustumFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double custumFee)
            : base(name, price)
        {
            CustumFee = custumFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                " (Custum fee: $ " +
                CustumFee.ToString("F2", CultureInfo.InvariantCulture) +
                ")";
        }

        public double TotalPrice()
        {
            return Price + CustumFee;
        }
    }
}
