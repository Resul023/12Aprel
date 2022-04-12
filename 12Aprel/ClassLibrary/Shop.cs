using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Shop
    {
        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order order) 
        {
            Orders.Add(order);
        }
        public double GetOrdersAvg(List<Order> Orders) 
        {
            double sum = 0;
            foreach (var item in Orders)
            {
                sum += item.TotalAmount;
            }
            return sum / Orders.Count;

        }
        public double GetOrdersAvg(DateTime CheckTime) 
        {

            double sum = 0;
            int count = 0;
            foreach (var item in Orders.FindAll((x) => x.CreatedAt > CheckTime))
            {
                sum += item.TotalAmount;
                count++;
            }return sum / count;

        }
        public void RemoveOrderByNo(int no) 
        {
            foreach (var item in Orders.FindAll((x) => x.No == no))
            {
                Orders.Remove(item);
                
            }
         
        }
        public List<Order> FilterOrderByPrice(int MinPrice, int MaxPrice) 
        {
            return Orders.FindAll(x => x.TotalAmount > MinPrice && x.TotalAmount < MaxPrice);
        
        }


    }
}
