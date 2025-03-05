using System;

public class Bank
{
    public static double InterestRate { get; private set; }

    public static void SetInterestRate(double newRate)
    {
        InterestRate = newRate;
    }
}
