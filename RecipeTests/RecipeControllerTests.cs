using informator.Controllers;
using informator.Data;
using NSubstitute;
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
        private ReceipeController sut;
        private IRecipeOperations roTest;
        /// <summary>
        /// En metod som körs innan testet kickar igång.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            roTest = Substitute.For<IRecipeOperations>();
            sut = new ReceipeController(roTest);
        }
        [Test]
        public void FullDetailsReturnsViewAndModel()
        {
            roTest.GetRecipe(0).Returns(new RecipeDetailsModel
            {
                Name = "Test Beer",
                Summary = "Tasty!"
            });
            //skapar ett objekt av controllern
            // var sut = new ReceipeController();

            //castar (nästan) objektet till kontrollermetoden
            var result = sut.FullDetails(1) as ViewResult;
            var model = result.Model as RecipeDetailsModel;
            //Assert.AreEqual(testModel.Name, model.Name, "Namnen stämmer");
            Assert.IsNotNull(result, "Got a ViewResult");
            Assert.IsNotNull(model.Summary, "har en sammanfattning");
            Assert.IsNotNull(model.Ingredients, "har en sammanfattning");
        }
    }



}
