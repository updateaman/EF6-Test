using System;
using System.ComponentModel.DataAnnotations;

namespace CoreWebApplication
{
    public class UserProfile //: ApplicationUser
    {
        [Key]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ProfilePhoto { get; set; }
        public string Interests { get; set; }
        public string AboutMe { get; set; }

        public Address Address { get; set; }

    }

    public class Address
    {
        [Key]
        public string AddressId { get; set; }

        public string City { get; set; }
        public string Street { get; set; }
        public string HouseOrFlatNumber { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string UserProfileForeignKey { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}

