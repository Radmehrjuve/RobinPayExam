//Question 2
//To use it, Set it as Startup Project in Solution Explorer
using Question2;

List<Product> itemlist = new List<Product>
            {
           new Product { Id = 1,  Name = "Biscuit  " },
           new Product { Id = 2,  Name = "Chocolate" },
           new Product { Id = 3,  Name = "Butter   " },
           new Product { Id = 4,  Name = "Brade    " },
           new Product { Id = 5,  Name = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvoiceNo=100, ProductId = 3,  Quantity = 800 },
           new Purchase { InvoiceNo=101, ProductId = 5,  Quantity = 650 },
           new Purchase { InvoiceNo=102, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=103, ProductId = 4,  Quantity = 700 },
           new Purchase { InvoiceNo=104, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=105, ProductId = 4,  Quantity = 650 },
           new Purchase { InvoiceNo=106, ProductId = 1,  Quantity = 458 }
            };

Console.Write("\nSample : Generate a Right Join between two data sets : ");
Console.Write("\n--------------------------------------------------\n");
Console.Write("Here is the Product List : ");
Console.Write("\n-------------------------\n");

// to do
foreach (Product prod in itemlist)
{
    Console.WriteLine($"Item Id: {prod.Id}, Title: {prod.Name}");
}

Console.Write("\nHere is the Purchase List : ");
Console.Write("\n--------------------------\n");

// to do
foreach (Purchase purchase in purchlist)
{
    Console.WriteLine($"InVoice No: {purchase.InvoiceNo}, Product Id: {purchase.ProductId}, Quantity: {purchase.Quantity}");
}

Console.Write("\nHere is the list after joining  : \n\n");


// to do


Console.WriteLine("Product ID\t\tProduct Name\tPurchase Quantity");
Console.WriteLine("-------------------------------------------------------");

foreach (Purchase purchase in purchlist)
{
    Product product = itemlist.FirstOrDefault(p => p.Id == purchase.ProductId);
    Console.WriteLine($"{product.Id}\t\t{product.Name}\t{purchase.Quantity}");
}
Console.ReadLine();