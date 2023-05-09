using CurrencyLotManagementLibrary.Enums;

namespace CurrencyLotManagementLibrary.Models.Entities;

public class Lot
{
    public string Id { get; set; } = null!;
    public string? PopReceipt { get; set; }
    public Currency Currency { get; set; }
    public double Amount { get; set; }
    public string SellerNickname { get; set; } = null!;
    public string? SellerSurname { get; set; }
    public TimeSpan ExpirationTime { get; set; }
}