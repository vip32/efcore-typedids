﻿using System;

namespace Domain
{
    public class Shipper
    {
        public Shipper()
        {
            //Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string HomePage { get; set; }

        public Address Address { get; set; }
    }
}
