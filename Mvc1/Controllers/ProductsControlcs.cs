using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Reflection.Metadata.Ecma335;

namespace Mvc1.Controllers
{
    public class ProductsControlcs : Controller
    {
        //BaseUrl/Products/Test
        public string Test()
        {
            return $"Hello from Test";
        }
        [HttpGet]
        public ContentResult Test() { 
        /*ContentResult result = new ContentResultC);
        result.ContentType = "text/htmL";
        result.Content = "Hello from test </br> Bye";
        result.StatusCode = 700;
        return result;*/
        return Content(content:$"hello</br>bye", contentType:"text/html");
        }
    }
}
