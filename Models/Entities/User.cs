using Microsoft.AspNetCore.Identity;

namespace CurrencyLotManagementLibrary.Models.Entities;

public class User : IdentityUser
{
    public string? Surname { get; set; }
}