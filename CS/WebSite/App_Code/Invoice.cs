using System;
using System.Collections.Generic;

public class Invoice {
    private string groupName;

    public string GroupName {
        get { return groupName; }
        set { groupName = value; }
    }
    private string description;

    public string Description {
        get { return description; }
        set { description = value; }
    }
    private decimal price;

    public decimal Price {
        get { return price; }
        set { price = value; }
    }

    public Invoice(string groupName, string description, decimal price) {
        this.GroupName = groupName;
        this.Description = description;
        this.Price = price;
    }

    public static List<Invoice> GetInvoices(string groupId) {
        List<Invoice> invoices = new List<Invoice>(10);
        Random rnd = new Random();

        if(groupId != "[All]") {
            for(int i = 0; i < 3; i++) {
                invoices.Add(new Invoice(groupId, "Invoice" + (i + 1).ToString(), rnd.Next(10, 30)));
            }
        }
        else {
            string[] groupIds = new string[] { "A", "B", "C" };
            
            for(int i = 0; i < 9; i++) {
                invoices.Add(new Invoice(groupIds[i / 3], "Invoice" + ((i + 1) % 3).ToString(), rnd.Next(10, 30)));
            }
        }

        return invoices;
    }

}
