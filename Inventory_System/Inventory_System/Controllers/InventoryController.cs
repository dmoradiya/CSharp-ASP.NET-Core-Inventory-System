﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory_System.Models;
using Inventory_System.Models.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_System.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        [HttpPost("Create")]
        public ActionResult<Product> ProductCreate_POST(string id, string name, string discontinue, string quantity)
        {
            ActionResult<Product> result;
            try
            {
                result = new ProductController().CreateProduct(id, name, discontinue, quantity);
            }
            catch (ValidationException e)
            {
                string error = "Error(s) During Creation: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception e)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }


    }
}