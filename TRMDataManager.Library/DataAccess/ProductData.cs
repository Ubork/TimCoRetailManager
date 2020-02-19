﻿using System.Collections.Generic;
using System.Linq;
using TRMDataManager.Library.Internal.DataAccess;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess("TRMData");

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { });

            return output;
        }

        public ProductModel GetProductById(int productId)
        {
            SqlDataAccess sql = new SqlDataAccess("TRMData");

            var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetById", new { Id = productId }).FirstOrDefault();

            return output;
        }
    }
}
