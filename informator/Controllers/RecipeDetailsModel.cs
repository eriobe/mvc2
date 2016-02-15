using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace informator.Controllers
{
    public class RecipeDetailsModel
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public int CookingTimeInMinutes { get; set; }
        public string Ingredients { get; set; }
        public string instructions { get; set; }
    }
}
}
}