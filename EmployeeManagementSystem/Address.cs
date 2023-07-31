namespace EmployeeManagementSystem
{
    internal class Address
    {
        // Attributes for Address class for better organization and abstraction.
        private string StreetAddress {get;set;}
        private string City { get;set;}
        private string State { get ; set;}
        private string ZipCode { get;set;}
        private string Country { get;set;}

        //Constructors
        // Default Constructor will just be 123 ABC St, Buffalo, NY, 14201, USA
        public Address()
        {
            StreetAddress = "123 ABC St";
            City = "Buffalo";
            State = "NY";
            ZipCode = "14201";
            Country = "USA";
        }

        public string PrintAddress()
        {
            return $"{StreetAddress}, {City}, {State} {ZipCode}, {Country}";
        }

    }
}