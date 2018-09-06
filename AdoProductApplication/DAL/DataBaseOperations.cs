using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Product.Model;


namespace DAL
{
    public sealed class DataBaseOperations : IDataBaseOperations
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataAdapter adp;
        private string connStr = @"Data Source=DESKTOP-D6FS7LS;Initial Catalog=SampleExercise;Integrated Security=True";
        private static readonly object padlock = new object();  
    private static DataBaseOperations instance = null;
        private DataBaseOperations()
        {

        }
    public static DataBaseOperations Instance () 
    {  
        
            if (instance == null)  
            {  
                lock (padlock)  
                {  
                    if (instance == null)  
                    {  
                        instance = new DataBaseOperations();  
                    }  
                }  
            }  
            return instance;  
         
    }  
    
    
    public int AddProduct(ProductList product)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd = new SqlCommand("insert into product (ProductName,ProductPrice,ProductCategoryById,ProductDate)" + "values(@ProductName,@ProductPrice,@ProductCategoryById,@ProductDate)", conn);
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
                cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                cmd.Parameters.AddWithValue("@ProductCategoryById", product.ProductCategoryById);
                DateTime dateTime = DateTime.Now;
                cmd.Parameters.AddWithValue("@ProductDate", DateTime.Now.ToString());
                var result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
        }
        public IEnumerable<ProductList> GetProducts()
        {

            using (conn = new SqlConnection(connStr))
            {
                List<ProductList> allProduct = new List<ProductList>();
                SqlCommand command = new SqlCommand("SELECT * FROM product ", conn);
                conn.Open();
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    allProduct.Add(new ProductList()
                    {
                        ProductId = Convert.ToInt32(rd["ProductId"]),
                        ProductName = rd["ProductName"].ToString(),
                        ProductPrice = Convert.ToInt32(rd["ProductPrice"]),
                        ProductCategoryById = Convert.ToInt32(rd["ProductCategoryById"]),
                        ProductDate = Convert.ToDateTime(rd["ProductDate"])
                    });
                    
                }
                if (allProduct.Count > 0)
                {
                    return allProduct;
                }

            }
            return null;
        }

        public ProductList GetProductsById(int productId)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM product where ProductId =" + productId;
                cmd = new SqlCommand(query, conn);

                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.HasRows)
                {
                    dr.Read();
                    return new ProductList
                    {
                        ProductId = Convert.ToInt32(dr[0]),
                        ProductName = dr[1].ToString(),
                        ProductPrice = Convert.ToInt32(dr[2]),
                        ProductCategoryById = Convert.ToInt32(dr[3]),
                        ProductDate = Convert.ToDateTime(dr[4])

                    };
                }
                return null;
            }

        }

        public void UpdateProduct(ProductList product)
        {
            using (conn = new SqlConnection(connStr))
            {
                product.ProductDate = DateTime.Now;
                conn.Open();
                string query = "UPDATE product SET " +
                    "ProductName ='" + product.ProductName +
                    "', ProductPrice = " + product.ProductPrice +
                    ", ProductCategoryById =" + product.ProductCategoryById +
                    ", ProductDate ='" + product.ProductDate
                    + "' where ProductID =" + product.ProductId;

                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

            }
        }

        public void DeleteProductId(int productId)
        {
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM product where ProductId = " + productId;
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
            }

        }


    }
}
