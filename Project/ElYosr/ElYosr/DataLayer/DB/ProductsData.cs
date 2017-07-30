using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElYosr.DataLayer
{
    class ProductsData
    {
        // constructor
        ProductsData()
        {
            // establishing connection 
        }

        // destructor
        ~ProductsData()
        {
            // closing connection
        }

        // add new product
        void add_new_product(Product pro)
        {

        }

        // get all products ( store )
        List<Product> getAll()
        {

        }

        // get product by id 
        Product getProductByID(int product_id)
        {

        }

        // get all unavilable products 
        List<Product> getAllUnAvailable()
        {

        }

        // get all avilable products 
        List<Product> getAllavilable()
        {

        }

        // update prodcut
        void update_Product(int product_id, Product new_product)
        {

        }

        // delete product
        void deleteProduct(int product)
        {

        }

        // get all products which is lessthan custom quantity
        List<Product> getLessThan(int quantity)
        {

        }


    }
}
