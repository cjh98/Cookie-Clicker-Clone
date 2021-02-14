using UnityEngine;

public class Building : MonoBehaviour
{
    public string type;

    public double cookiesPerSecond;
    public double baseCost;

    public int amount = 0;

    double priceMod = 1.15;

    void Start()
    {

    }

    void FixedUpdate()
    {
        Game.BakeCookies(cookiesPerSecond * amount);
    }

    public void Purchase()
    {
        double price = CalcPrice();

        if (Game.currentCookies >= price)
        {
            Game.UseCookies(price);
            amount++;

            Game.totalCookiesPerSecond += cookiesPerSecond;
        }
    }

    public double CalcPrice()
    {
        return baseCost * System.Math.Pow(priceMod, amount);
    }
}
