using System;
using System.Collections.Generic;

namespace OOPsIDidItAgain._01.SuperController.Web.Data
{
    public class Cart
    {
        public Guid Id { get; set; }

        public IEnumerable<CartItem> Items { get; set; }
    }
}