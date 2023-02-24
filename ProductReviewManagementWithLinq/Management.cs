using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        //UseCase1
        public void ProductPrint(List<ProductReview> productReviews)
        {
            Console.WriteLine("Displaying all data");
            foreach (var product in productReviews)
            {
                Console.WriteLine($"ProductId: {product.ProductId}, UserId: {product.UserId}, Rating: {product.Rating}, Review: {product.Review}, IsLike: {product.IsLike}");
            }
        }
        //UseCase2
        public void Top3Record(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Dispalying Top Three Records----");

            var recordData = (from ProductReview in listproductReviews
                              orderby ProductReview.Rating descending
                              select ProductReview
                            ).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating);
            }

        }
        //UseCase3
        public void selectedRecords(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Retrieve who’s rating are greater then 3----");
            var recordData = (from ProductReview in listproductReviews
                              where (ProductReview.ProductId == 1 || ProductReview.ProductId == 4 || ProductReview.ProductId == 9)
                              && ProductReview.Rating > 3
                              select ProductReview
                               );

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        //UseCase4
        public void countedRecords(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Retrieve Count Of Review Present for each productID");
            var recordData = listproductReviews.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list.productId + " = " + list.count);
            }
        }
        //UseCase5
        public void retriveOnlyProductId(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Retrieve only productId and review from the list----");
            var recordData = listproductReviews.Select(x => x.ProductId).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list);
            }

        }
        //UseCase6
        public void skipRecords(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Skip top 5 records from the list----");
            var recorData = listproductReviews.Skip(5).ToList();
            foreach (var list in recorData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserID:-" + list.UserId + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.IsLike);
            }
        }
        //UseCase7
        public void retriveOnlyProductIdBySelect(List<ProductReview> listproductReviews)
        {
            Console.WriteLine("----Retrieve only productId and review from the list----");
            var recordData = listproductReviews.Select(x => x.ProductId).ToList();
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId:-" + list);
            }

        }
    }
}

