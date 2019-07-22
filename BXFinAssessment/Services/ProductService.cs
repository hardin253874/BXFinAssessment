using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BXFinAssessment.Services
{
    public class ProductService : IProductService
    {
        public ProductService()
        {

        }

        public int[] Reverse(int[] productIds)
        {
            for (int i = 0; i < productIds.Length / 2; i++) {
                int tmp = productIds[i];
                productIds[i] = productIds[productIds.Length - i - 1];
                productIds[productIds.Length - i - 1] = tmp;
            }

            return productIds;
        }

        public int[] DeletePart(int position, int[] productIds)
        {
            var newProductIds = new int[productIds.Length - 1];

            for (int i = 0; i < productIds.Length; i++) {
                if (i < position - 1) {
                    newProductIds[i] = productIds[i];
                } else if (i > position - 1) {
                    newProductIds[i - 1] = productIds[i];
                }

            }
            return newProductIds;
        }
    }
}