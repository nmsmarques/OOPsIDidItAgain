﻿using System;

namespace OOPsIDidItAgain._03.IndividualRequestHandlers.Web.Models
{
    public class AddItemToCartModel
    {
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
    }
}
