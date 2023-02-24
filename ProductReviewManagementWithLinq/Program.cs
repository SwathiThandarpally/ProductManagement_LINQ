using ProductReviewManagementWithLinq;
using System.Collections.Generic;

namespace ProductReviewManagementWitLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dispalying ProductManganementReview");
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 2, UserId = 1, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 1, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 1, UserId = 6, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 8, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 7, UserId = 2, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 8, UserId = 3, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 4, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 1, UserId = 7, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 7, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 12, UserId = 1, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 13, UserId = 3, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 14, UserId = 6, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 15, UserId = 6, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 1, UserId = 8, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 17, UserId = 9, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 18, UserId = 11, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 15, Rating = 1, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 9, UserId = 5, Rating = 4, Review = "Good", IsLike = true },
            };
            
            Management management = new Management();
            
            //management.ProductPrint(productReviews);

            //management.Top3Record(productReviews);

            //management.selectedRecords(productReviews);

            //management.countedRecords(productReviews);

            //management.retriveOnlyProductId(productReviews);

            management.skipRecords(productReviews);
        }
    }
}