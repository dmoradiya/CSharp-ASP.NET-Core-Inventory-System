using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_System.Models;
using Inventory_System.Models.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_System.Controllers
{
    public class ProductController : Controller
    {
        // Action
        public IActionResult Index()
        {
            return View();
        }

        // Method
        public Product CreateProduct(string id, string name,  string discontinue, string quantity= "0")
        {
            int parsedID = 0;
            int parsedQuantity = 0;

            ValidationException exception = new ValidationException();

            id = !string.IsNullOrWhiteSpace(id) ? id.Trim() : null;
            name = !string.IsNullOrWhiteSpace(name) ? name.Trim() : null;
            quantity = !string.IsNullOrWhiteSpace(quantity) ? quantity.Trim() : null;
            discontinue = !string.IsNullOrWhiteSpace(discontinue) ? discontinue.Trim().ToLower() : null;


            using (InventoryContext context = new InventoryContext())
            {
                // Id Validation
                if (string.IsNullOrWhiteSpace(id))
                {
                    exception.ValidationExceptions.Add(new Exception("Category ID not Provided"));
                }
                else
                {
                    if (!int.TryParse(id, out parsedID))
                    {
                        exception.ValidationExceptions.Add(new Exception("ID not Valid"));
                    }
                    else
                    {
                        if (!context.Products.Any(x=>x.ID == parsedID))
                        {
                            exception.ValidationExceptions.Add(new Exception("Product Does Not Exist"));
                        }
                    }
                }
                // Name Validation
                if (string.IsNullOrWhiteSpace(name))
                {
                    exception.ValidationExceptions.Add(new Exception("Name Not Provided"));
                }
                else
                {

                    if (context.Products.Any(x => x.Name.ToUpper() == name.ToUpper()))
                    {
                        exception.ValidationExceptions.Add(new Exception("Name Already Exists"));
                    }
                    else
                    {
                        if (name.Length > 30)
                        {
                            exception.ValidationExceptions.Add(new Exception("The Maximum Length of a Name is 30 Characters"));
                        }
                    }

                }
                // Quantity Validation
                if (string.IsNullOrWhiteSpace(quantity))
                {
                    exception.ValidationExceptions.Add(new Exception("Quantity not Provided"));
                }
                else
                {
                    if (!int.TryParse(id, out parsedQuantity))
                    {
                        exception.ValidationExceptions.Add(new Exception("Quantity not Valid"));
                    }
                    else
                    {
                        if (parsedQuantity < 0)
                        {
                            exception.ValidationExceptions.Add(new Exception("Quantity Cannot be Negative Value"));
                        }
                    }
                }
                // Discontinue Validation
                if (string.IsNullOrWhiteSpace(discontinue))
                {
                    exception.ValidationExceptions.Add(new Exception("Discontinue Note Provided"));
                }
                else
                {

                    if (discontinue.Length !=4 || discontinue.Length != 5  )
                    {
                        exception.ValidationExceptions.Add(new Exception("Only Accept 'true' OR 'false' value"));
                    }
                    
                }
                if (exception.ValidationExceptions.Count > 0)
                {
                    throw exception;
                }

                Product newProduct = new Product()
                {
                    ID = parsedID,
                    Name = name,
                    Discontinue = Convert.ToBoolean(discontinue),
                    Quantity = parsedQuantity
                };
                context.Products.Add(newProduct);
                context.SaveChanges();
                return newProduct;
            }
        }
        public Product DiscontinueProductByID(string id)
        {
            Product result;
            int parsedID = 0;

            ValidationException exception = new ValidationException();

            id = !string.IsNullOrWhiteSpace(id) ? id.Trim() : null;

            using (InventoryContext context = new InventoryContext())
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    exception.ValidationExceptions.Add(new Exception("Category ID not Provided"));
                }
                else
                {
                    if (!int.TryParse(id, out parsedID))
                    {
                        exception.ValidationExceptions.Add(new Exception("ID not Valid"));
                    }
                    else
                    {
                        if (!context.Products.Any(x => x.ID == parsedID))
                        {
                            exception.ValidationExceptions.Add(new Exception("Product Does Not Exist"));
                        }
                    }
                }

                result = context.Products.Where(x => x.ID == parsedID).SingleOrDefault();
                if (result.Discontinue == true)
                {
                    exception.ValidationExceptions.Add(new Exception("Product is Already Disconinued"));
                }
                else
                {
                    result.Discontinue = true;
                    context.SaveChanges();
                }
            }
           
            return result;
        }

    }
}
