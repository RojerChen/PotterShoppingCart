using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PotterShoppingCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests {
    [TestClass()]
    public class PotterShoppingCartTests {

        [TestMethod()]
        public void Calcute_買第一集一本_共100元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });


            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double expect = shoppingCart.Calcute(Books);

            
            //assert
            Assert.AreEqual(100,expect);

        }

        [TestMethod()]
        public void Calcute_買第一集一本_第二集一本_共190元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 1
            });

            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(190,result);

        }

        [TestMethod()]
        public void Calcute_買第一集一本_第二集一本_第三集一本_共270元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_III,
                Quantity = 1
            });

            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(270, result);

        }

        [TestMethod()]
        public void Calcute_買第一集一本_第二集一本_第三集一本_第四集一本_共320元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_III,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_IV,
                Quantity = 1
            });

            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(320, result);

        }

        [TestMethod()]
        public void Calcute_買第一集一本_第二集一本_第三集一本_第四集一本_第五集一本_共375元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_III,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_IV,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_V,
                Quantity = 1
            });
            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(375, result);

        }


        [TestMethod()]
        public void Calcute_買第一集一本_第二集一本_第三集二本_共460元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_III,
                Quantity = 2
            });

   
            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(370, result);

        }


        [TestMethod()]
        public void Calcute_第一集買了一本_第二集二本_第三集二本_共460元() {

            //arrange
            List<HorryPotter> Books = new List<HorryPotter>();
            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_I,
                Quantity = 1
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_II,
                Quantity = 2
            });

            Books.Add(new HorryPotter() {
                Title = Title.HarryPotter_III,
                Quantity = 2
            });


            //act
            IPotterShoppingCart shoppingCart = new PotterShoppingCart();
            double result = shoppingCart.Calcute(Books);


            //assert
            Assert.AreEqual(460, result);

        }
    }
}
