using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public string Attr4 { get; set; }
        public string Attr5 { get; set; }
        public DateTime? Attr6 { get; set; }
        public DateTime? Attr7 { get; set; }
        public List<OrderDto> Orders { get; set; }

    }

    public class OrderDto
    {
        public Guid Id { get; set; }
        public int RowNumber { get; set; }
        public string ProductName { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public string Attr4 { get; set; }
        public string Attr5 { get; set; }
        public DateTime? Attr6 { get; set; }
        public DateTime? Attr7 { get; set; }
    }

    public class DummyDto
    {
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }
        public string Attr4 { get; set; }
        public string Attr5 { get; set; }
        public DateTime? Attr6 { get; set; }
    }
}
