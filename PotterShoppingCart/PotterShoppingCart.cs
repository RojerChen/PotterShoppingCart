using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart {

 
    
    public class PotterShoppingCart : IPotterShoppingCart   {

        /// <summary>
        /// 計算金額
        /// </summary>
        /// <param name="Books"></param>
        /// <returns></returns>
        public double Calcute(List<HorryPotter> Books) {
            double totalPrice = 0;
            double forLoop = 0;
            int category = 0;
            double sum = 0;

            //依照書籍的 Title 歸類各類的總數
            var HorryPotterBooks = Books.GroupBy(x => new {x.Title , x.Price} )
                            .Select(y => new {
                                Title = y.Key.Title,
                                Quality = y.Sum(z => z.Quantity),
                                Price = y.Key.Price
                            });
 
            forLoop = HorryPotterBooks.Select(x => x.Quality).Max();

            //                        loop 1  loop2
            // Horry Potter I   :1     1<=1    
            // Horry Potter II  :2     1<=1    2<=2
            // Horry Potter III :2     1<=1    2<=2
            //     total                3        2
            //     discount             0.9     0.95

            
            for (double i = 1; i <= forLoop; i++) {
                category = 0;
                sum = 0;
                foreach (var item in HorryPotterBooks) {
                    if (item.Quality >= i) {
                        category += 1;
                        sum += item.Price;
                    }
                }
                totalPrice +=  GetDiscount(category) * sum;
            }
 
            return totalPrice;
        }




        /// <summary>
        /// 取得折扣數
        /// </summary>
        /// <param name="count">書籍種類</param>
        /// <returns></returns>
        private double GetDiscount(int count) {
            switch (count) {
                case 1:
                default:
                    return 1;
                case 2:
                    return 0.95;
                case 3:
                    return 0.9;
                case 4:
                    return 0.8;
                case 5:
                    return 0.75;
            }
        }
    
    }

    public class HorryPotter {
        public Title Title { get; set; }

        public double Quantity { get; set; }

        public double Price {
            get {
                return 100;
            }
        }
    }


    public enum Title {
        HarryPotter_I,
        HarryPotter_II,
        HarryPotter_III,
        HarryPotter_IV,
        HarryPotter_V
    };

}
