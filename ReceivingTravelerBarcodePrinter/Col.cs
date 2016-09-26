using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceivingTravelerBarcodePrinter
{
    public static class Col
    {
       public const int colPO = 0;
       public const int colSupplier = 1;
       public const int colPN = 2;
       public const int colREV = 3;
       public const int colQTY = 4;
       public const int colDATECODE = 5;
       public const int colDN = 6;
       public const int colWO = 7;
       public const int colPalletNO = 8;
       public const int colDate = 9;
       public const int colRemark = 10;

       private static List<int> notNullColumns = new List<int>
       {
           colPO,colSupplier,colPN,colQTY,colDN
       };
       public static List<int> NotNullColumns
       {
           get { return notNullColumns; }
       }
    }
}
