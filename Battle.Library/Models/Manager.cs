using System;
using System.Collections.Generic;
using System.Text;

namespace Battle.Library.Models
{
    public class Manager
    {
        public int managerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public int RestaurantId { get; set; }


        public string Fullname
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        //public string RestaurantNaam
        //{
        //    get
        //    {
        //        switch (RestaurantId)
        //        {
        //            case 1:
        //                return "Zwolle-Noord";
        //            case 2:
        //                return "Zwolle-Zuid";
        //            case 3:
        //                return "Heerde";
        //            case 4:
        //                return "Kampen";
        //            case 5:
        //                return "Zwolle-Centrum";
        //            default:
        //                return "Geen restaurant gevonden";

        //        }
        //    }
        //}

    }
}
