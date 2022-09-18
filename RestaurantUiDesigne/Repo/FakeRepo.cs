using RestaurantUiDesigne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
            };
        } 
    }
}
