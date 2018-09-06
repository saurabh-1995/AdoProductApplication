using Product.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IDataBaseOperations
    {
        /// <summary>
        /// This method Is Used For Adding A New Product
        /// </summary>
        /// <param name="product">AllProducts Object</param>
        /// <returns>int</returns>
        int AddProduct(ProductList product);

        IEnumerable<ProductList> GetProducts();
        void UpdateProduct(ProductList product);
        void DeleteProductId(int productId);

    }
}
