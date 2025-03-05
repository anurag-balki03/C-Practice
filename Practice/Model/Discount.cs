using System;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal totalAmount);
}

public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount;
    }
}

public class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - (totalAmount * _percentage / 100);
    }
}

public class FixedAmountDiscount : IDiscountStrategy
{
    private readonly decimal _fixedAmount;

    public FixedAmountDiscount(decimal fixedAmount)
    {
        _fixedAmount = fixedAmount;
    }

    public decimal ApplyDiscount(decimal totalAmount)
    {
        return totalAmount - _fixedAmount;
    }
}

public class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal totalAmount)
    {
        return _discountStrategy.ApplyDiscount(totalAmount);
    }
}