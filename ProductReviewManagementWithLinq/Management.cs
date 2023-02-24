using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public void ProductPrint(List<ProductReview> productReviews)
        {
            Console.WriteLine("Displaying all data");
            foreach (var product in productReviews)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, UserId: {product.UserId}, Rating: {product.Rating}, Review: {product.Review}, IsLike: {product.IsLike}");
            }
        }

    }
}

