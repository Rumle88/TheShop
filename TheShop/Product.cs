using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheShop
{
    public class Product
    {
       private int proid = 0;
       public void setOrderid(int id)
       {
           if (id > 0)
           {
               proid = id;
           }
       }
       public int ProId { get; set;}
	   public string ProName {get; set;}
	   public string Info {get; set;}
       public string Proinfo {get; set;}
	   public int ProPrice {get; set;}
       public string ProType {get; set;}
    }
}
