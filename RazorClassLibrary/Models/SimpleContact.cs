using System;

namespace ContactsHybridWebApp.Models;

public class SimpleContact
{
    public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsFav { get; set; } = false;
}