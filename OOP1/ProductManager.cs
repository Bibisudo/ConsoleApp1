using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1 //Burası metodumuzun nasıl çağırılacağını anlattığımız yer.
{
    class ProductManager 
    {
        public void Add(Product product) //Metod: beni manager içinden çağıracaksın, benim adım Add, bana bi parametre ver.Product türünde bi product lazım.
        {
            //product.ProductName = "Kamera"; //heapteki yani adressteki değeri kamera yaptığın için, adı değişir.
            Console.WriteLine(product.ProductName + " Eklendi.");
        }
        public void Update(Product product) 
        {

            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
    }
}
