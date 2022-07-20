using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ProductData
    {
        private readonly ISqlDataAccess _db;
        
        public ProductData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<IEnumerable<ProductModel>> GetProducts() =>
           _db.LoadData<ProductModel, dynamic>(
                storedProcedure:"dbo.spProducts_GetAll", 
                new {});
        public async Task<ProductModel?> GetProduct(int id)
        {
            var results = await _db.LoadData<ProductModel, dynamic>(
                storedProcedure: "dbo.spProducts_Get",
                new { Id = id });
            return results.FirstOrDefault();
        }
        public Task InsertProduct(ProductModel product) =>
            _db.SaveData(storedProcedure: "dbo.spProducts_Insert",
                new { product.Name, product.Description, product.Price, product.Category });

        public Task UpdateProduct(ProductModel product) =>
            _db.SaveData(storedProcedure: "dbo.spProducts_Update", product);

        public Task DeleteProduct(int id) =>
            _db.SaveData(storedProcedure: "dbo.spProducts_Delete", new { Id = id });
    }
}
