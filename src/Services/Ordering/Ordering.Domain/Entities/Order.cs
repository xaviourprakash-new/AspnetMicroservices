﻿using Ordering.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordering.Domain.Entities
{
    public class Order : EntityBase
    {
        public string? UserName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? TotalPrice { get; set; }

        // BillingAddress
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? AddressLine { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }

        // Payment
        public string? CardName { get; set; }
        public string? CardNumber { get; set; }
        public string? Expiration { get; set; }
        public string? CVV { get; set; }
        public int? PaymentMethod { get; set; }
    }
}
