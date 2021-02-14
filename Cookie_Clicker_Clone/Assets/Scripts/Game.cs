using System.Collections.Generic;

public static class Game
{
    public static double currentCookies;
    public static double totalCookies;

    public static double timeStep = 0.02;

    public static double totalCookiesPerSecond = 0;

    public static void BakeCookies(double amount)
    {
        currentCookies += amount * timeStep;
        totalCookies += amount * timeStep;
    }

    public static void UseCookies(double amount)
    {
        currentCookies -= amount;
    }
}
