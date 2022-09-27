using RestaurantUiDesigne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUiDesigne.Repo
{
    public class FakeRepo
    {
        public List<ImageClass> GetAllImage()
        {
            return new List<ImageClass>
            {
                new ImageClass
                {
                    Image="/Image/home2.png",
                },
                new ImageClass
                {
                    Image="/Image/pizza.png"
                },
                new ImageClass
                {
                    Image="/Image/foods.png"
                },
                new ImageClass
                {
                    Image="/Image/drink.png"
                }
            };
        }

        public List<Eat> GetAllEat()
        {
            return new List<Eat>
            {
                new Eat
                {
                    Description="Spicy seasoned seafood noodles",
                    Price=2.70,
                    Image="/Image/eat10.png"
                },

                new Eat
                {
                    Description="Salted paste with mushroom sauce",
                    Price=4.40,
                    Image="/Image/eat11.png"
                },

                new Eat
                {
                    Description="Beef Dumpling in hot and sour",
                    Price=4.60,
                    Image="/Image/eat12.png"
                },
                new Eat
                {
                    Description="Health noodle with spinach leaf",
                    Price=7.79,
                    Image="/Image/eat13.png"
                },
                new Eat
                {
                    Description="Hot spicy fried rice with omlet",
                    Price=5.50,
                    Image="/Image/eat14.png",
                },
                new Eat
                {
                    Description="Spicy instant noodle with special omelette",
                    Price=8.70,
                    Image="/Image/eat15.png"
                },
                new Eat
                {
                    Description="Spicy seasoned seafood noodles",
                    Price=2.70,
                    Image="/Image/eat10.png"
                },

                new Eat
                {
                    Description="Salted paste with mushroom sauce",
                    Price=5.68,
                    Image="/Image/eat11.png"
                },

                new Eat
                {
                    Description="Beef Dumpling in hot and sour",
                    Price=4.60,
                    Image="/Image/eat12.png"
                },
                new Eat
                {
                    Description="Health noodle with spinach leaf",
                    Price=7.79,
                    Image="/Image/eat13.png"
                },
                new Eat
                {
                    Description="Hot spicy fried rice with omlet",
                    Price=5.50,
                    Image="/Image/eat14.png",
                },
                new Eat
                {
                    Description="Spicy instant noodle with special omelette",
                    Price=8.70,
                    Image="/Image/eat15.png"
                }
            };
        }
    }
}
