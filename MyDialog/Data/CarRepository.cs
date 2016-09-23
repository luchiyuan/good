using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyDialog.Models;
namespace MyDialog.Data
{
    public static class CarRepository
    {
        static List<CarModel> CarList;

        static CarRepository()
        {
            CarList = new List<CarModel>{
                new CarModel { Id=1, Name="Ford Focus Electric", Description = "Great looking car... plus is green."},
                new CarModel { Id=2, Name="Honda Civic 2012", Description="You can always count with the Civic"},
                new CarModel { Id=3, Name="Hyundai HCD 12", Description="Can't wait for it to come out!"},
                new CarModel { Id=4, Name="Toyota Prius C", Description="What does the C stands for?"}};
        }

        /// <summary>
        /// NOTE: This is for demostration purposes only. 
        ///         You would normally have your data access layer, either on the web app or in other libraries.
        /// </summary>
        /// <returns></returns>
        public static List<CarModel> GetCars()
        {
            return CarList;
        }
    }
}