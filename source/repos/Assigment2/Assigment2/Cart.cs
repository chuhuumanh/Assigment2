using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment2
{
    class Cart
    {
        int id;
        String customer;
        double grandTotal;
        List<Product> productList;
        String coutry;
        String city;

        public Cart()
        {
        }

        public Cart(int id, string customer, double grandTotal, List<Product> productList, string coutry, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.productList = productList;
            this.coutry = coutry;
            this.country = country;
        }
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void removeProduct(int index)
        {
            productList.RemoveAt(index);
        }
        public double checkgrandTotal(){
            if(this.city.Equals("Hà Nội")){
            return    this.grandTotal= grandTotal / 100 *1 ;
}else if(!this.coutry.Equals("Việt Nam")){
              return  this.grandTotal= grandTotal / 100 *5 ;

}
          else {
                return this.grandTotal= grandTotal / 100 *5;
}


}


}

    }
}
