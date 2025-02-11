namespace webapp.Models
{
    public class Property
    {
    
            public int Id { get; set; }
            public bool IsHomeOwner { get; set; }
            public string Adress { get; set; }

            public int ZipCode { get; set; }

            public string City { get; set; }

            public DateTime Bought { get; set; }

            public bool Hasloan { get; set; }

            public string LoanType { get; set; }

            public double InterestRate { get; set; }

        
    }


}
