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
    public class HomeControllerTests
    {
        //public object NumberOfRecipes { get; private set; }

        [Test]
        public void SiteStatisticsPopulatesViewBag()
        {
            var sut = new HomeController();

            var result = sut.SiteStatistics() as ViewResult;


            //undersöker om det finns ett värde i variabeln NumberOfRecipes
            Assert.IsInstanceOf<int>(result.ViewBag.NumberOfRecipes);
            Assert.IsTrue(result.ViewBag.NumberOfRecipes == 1);

        }
    }
}
