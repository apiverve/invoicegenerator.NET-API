using System;
using System.Collections.Generic;
using System.Text;

namespace APIVerve
{
    public class InvoiceGeneratorQueryOptions {
public string invoiceNumber { get; set; }
public string from_name { get; set; }
public string from_street { get; set; }
public string from_city { get; set; }
public string from_state { get; set; }
public string from_zip { get; set; }
public string to_name { get; set; }
public string to_street { get; set; }
public string to_city { get; set; }
public string to_state { get; set; }
public string to_zip { get; set; }
public string job { get; set; }
public string paymentTerms { get; set; }
public string dueDate { get; set; }
public decimal discount { get; set; }
public decimal salesTax { get; set; }
public string currency { get; set; }
public array items { get; set; }
}
}
