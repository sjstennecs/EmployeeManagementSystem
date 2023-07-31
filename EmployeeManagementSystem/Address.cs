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

        public string PrintAddress()
        {
            return $"{StreetAddress} {City}, {State} {ZipCode}, {Country}";
        }

    }
}