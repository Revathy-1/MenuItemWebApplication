using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuItemWebApplication.Models;

namespace MenuItemWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetMenuItem()
        {
            List<MenuItem> MenuItemList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Samosa", Active=true, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=15},
                new MenuItem() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=80},
                 new MenuItem() {Id=3, Name="Burger", Active=true, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=70},
                 new MenuItem() {Id=4, Name="OrangeJuice", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=50},
                 new MenuItem() {Id=5, Name="MangoJuice", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=60}


            };
            return MenuItemList;
        }

        [HttpGet("{id}")]
        public MenuItem GetMenuItemById(int id)
        {
            List<MenuItem> MenuItemList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Samosa", Active=true, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=15},
                new MenuItem() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=80},
                 new MenuItem() {Id=3, Name="Burger", Active=true, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=70},
                 new MenuItem() {Id=4, Name="OrangeJuice", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=50},
                 new MenuItem() {Id=5, Name="MangoJuice", Active=false, DateOfLaunch=new DateTime(2022,01,02), FreeDelivery=false,Price=60}
            };
            MenuItem value = MenuItemList.SingleOrDefault(item => item.Id == id);
            return value;

        }
    }
}
