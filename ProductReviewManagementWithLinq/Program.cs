using ProductReviewManagementWithLinq;
using System.Collections.Generic;

namespace ProductReviewManagementWitLinq
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dispalying ProductManganementReview");
            List<ProductReview> productReviews = new List<ProductReview>();
            {

                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 2, UserId = 1, Rating = 3, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 3, UserId = 1, Rating = 4, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 4, UserId = 1, Rating = 1, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 9, UserId = 1, Rating = 2, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 7, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 8, UserId = 1, Rating = 2, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 9, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 4, UserId = 1, Rating = 4, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 12, UserId = 1, Rating = 2, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 13, UserId = 1, Rating = 3, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 14, UserId = 1, Rating = 4, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 15, UserId = 1, Rating = 2, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 17, UserId = 1, Rating = 3, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 18, UserId = 1, Rating = 2, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 4, UserId = 1, Rating = 1, Review = "Good", IsLike = true };
                new ProductReview() { ProductId = 9, UserId = 1, Rating = 4, Review = "Good", IsLike = true };


            };

            Management management = new Management();
            // management.ProductPrint(productReviews);
            // management.RetriveProductId(productReviews);
            management.PrintTopThreeRecords(productReviews);
        }
    }
}