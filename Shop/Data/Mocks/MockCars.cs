using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {name = "Tesla Model S",
                        shortDesc="Экономичный и доступный",
                        longDesc = "Best seller компании Tesla",
                        img="https://www.google.com/imgres?imgurl=https%3A%2F%2Fmotor.ru%2Fthumb%2F2250x0%2Ffilters%3Aquality(75)%3Ano_upscale()%2Fimgs%2F2020%2F04%2F25%2F22%2F3883777%2F35a8fa2163d04f4503a77a8ef2d7b5483737259a.jpg&imgrefurl=https%3A%2F%2Fmotor.ru%2Fnews%2Ftesla-performance-dynamic-25-04-2020.htm&tbnid=uv_R91aEwCr8pM&vet=12ahUKEwj2pcrwr4nzAhVJsCoKHZ-5BbsQMygAegUIARDOAQ..i&docid=I12NIqOKFjMaxM&w=1816&h=1211&q=tesla%20model%20s&ved=2ahUKEwj2pcrwr4nzAhVJsCoKHZ-5BbsQMygAegUIARDOAQ",
                        price = 45000,
                        isFavourite= true,
                        available=true,
                        Category = _categoryCars.AllCategories.First() },

                    new Car {name = "Tesla Model X",
                        shortDesc="Экономичный и семейный",
                        longDesc = "SUV компании Tesla",
                        img="https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.motor1.com%2Fimages%2Fmgl%2FKNy0G%2Fs1%2Frefreshed-tesla-model-x.webp&imgrefurl=https%3A%2F%2Fru.motor1.com%2Fnews%2F482739%2Ftesla-model-x-plaid-debut%2F&tbnid=bZ3N74QM3l77IM&vet=12ahUKEwiujeKtsInzAhUBsCoKHTn0C5UQMygBegUIARDRAQ..i&docid=5ITaOs0ddUSH5M&w=1920&h=1080&q=tesla%20model%20x&ved=2ahUKEwiujeKtsInzAhUBsCoKHTn0C5UQMygBegUIARDRAQ",
                        price = 56000,
                        isFavourite= true,
                        available=true,
                        Category = _categoryCars.AllCategories.First() },

                    new Car {name = "Nissan Leaf",
                        shortDesc="Экономичный и компактный",
                        longDesc = "Best seller компании Nissan в этом сегменте",
                        img = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.motor1.com%2Fimages%2Fmgl%2FOOzeR%2Fs3%2F2020-nissan-leaf-jdm.jpg&imgrefurl=https%3A%2F%2Fru.motor1.com%2Fnews%2F388138%2Fnissan-leaf-stal-bogache-i-poumnel%2F&tbnid=7qWDdEfjC9Ug5M&vet=12ahUKEwiHi7PwsInzAhVYyyoKHQnRAcMQMygRegUIARDyAQ..i&docid=FySxxAGPTRfreM&w=1280&h=720&q=nissan%20leaf&ved=2ahUKEwiHi7PwsInzAhVYyyoKHQnRAcMQMygRegUIARDyAQ",
                        price = 22000,
                        isFavourite= true,
                        available=true,
                        Category = _categoryCars.AllCategories.First() },

                    new Car {name = "Ford Raptor",
                        shortDesc="Пикап от Ford",
                        longDesc = "Эта машина не про экономию, а про эмоции от езды по бездорожью",
                        img="https://www.google.com/imgres?imgurl=https%3A%2F%2Fdomvdorogu.ru%2Fimg%2Fford%2Fcq5dam.web.768.768_1.jpeg&imgrefurl=https%3A%2F%2Fdomvdorogu.ru%2Fcaravans%2Fford%2Ff_150-raptor&tbnid=0VzAwbpT_MxWAM&vet=12ahUKEwish4KcsYnzAhUPzioKHd9KACYQMygOegUIARDrAQ..i&docid=Fqn26seYRvFgKM&w=768&h=512&q=ford%20raptor&ved=2ahUKEwish4KcsYnzAhUPzioKHd9KACYQMygOegUIARDrAQ",
                        price = 53000,
                        isFavourite= true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last() },


                    new Car {name = "Jeep Gladiator",
                        shortDesc="Длиннобазный Wrangler возвращается",
                        longDesc = "Пикап от компании Jeep, они знают толк в бездорожье",
                        img="https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn.motor1.com%2Fimages%2Fmgl%2FbonKn%2Fs1%2F2020-jeep-gladiator-lead-image.jpg&imgrefurl=https%3A%2F%2Fru.motor1.com%2Fjeep%2Fgladiator%2F&tbnid=LYf90G3CJ4-bGM&vet=12ahUKEwjiw_zXsYnzAhVRCRAIHURuBhUQMygFegUIARDTAQ..i&docid=Xo3QIMDMRXIKEM&w=1920&h=1080&q=jeep%20gladiator&ved=2ahUKEwjiw_zXsYnzAhVRCRAIHURuBhUQMygFegUIARDTAQ",
                        price = 58000,
                        isFavourite= true,
                        available=true,
                        Category = _categoryCars.AllCategories.Last() },

                };

            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
