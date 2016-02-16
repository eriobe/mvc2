using informator.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RecipeTests
{
    [TestFixture]
    public class RecipeControllerTests
    {
        [Test]
        public void FullDetailsReturnsViewAndModel()
        {
            //skapar ett objekt av controllern
            var sut = new ReceipeController();
           

            //castar (nästan) objektet till kontrollermetoden
            var result = sut.FullDetails() as ViewResult;
          
            Assert.IsNotNull(result, "Got a ViewResult");
        }
    }



}
