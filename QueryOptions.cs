using System;
using System.Collections.Generic;
using System.Text;

namespace APIVerve
{
    public class InvoiceGeneratorQueryOptions {
public string InvoiceNumber { get; set; }
public string Date { get; set; }
public string DueDate { get; set; }
public object From { get; set; }
public object To { get; set; }
public string Job { get; set; }
public string PaymentTerms { get; set; }
public int Discount { get; set; }
public double SalesTax { get; set; }
public string Currency { get; set; }
public object[] Items { get; set; }
}
}
