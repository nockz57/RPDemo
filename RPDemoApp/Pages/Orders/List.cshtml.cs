using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RPDemoApp.Pages.Orders
{
    public class ListModel : PageModel
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        public List<OrderModel> Orders { get; set; }

        //public OrderModel Order { get; set; }
       // public string ItemPurchased { get; set; }

        public ListModel(IOrderData orderData, IFoodData foodData)
        {
            _orderData = orderData;
            _foodData = foodData;
        }
        public async Task OnGet()
        {
            Orders = await _orderData.GetOrders();

            //var food = await _foodData.GetFood();

            //foreach (var foodItem in Orders)
            //{
            //    ItemPurchased = food.Where(x => x.Id == foodItem.FoodId).FirstOrDefault()?.Title;
                
            //}

            //ItemPurchased = food.Where(x => x.Id == Order.FoodId).FirstOrDefault()?.Title;
        }
    }
}