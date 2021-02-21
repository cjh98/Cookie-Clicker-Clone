
public class Building
{
    public string type;
    public double baseCost;
    public double cookiesPerSecond;
    
    public int amount = 0;
    public int level = 1;

    double newCostFactor = 1.15;

    public Building(string type, double baseCost, double cookiesPerSecond)
    {
        this.type = type;
        this.baseCost = baseCost;
        this.cookiesPerSecond = cookiesPerSecond;
    }

    public void Purchase()
    {
        Game.thisGame.currentCookies -= GetPrice();
        amount++;
    }

    public void Upgrade()
    {
        level++;
    }

    public double GetPrice()
    {
        return baseCost * System.Math.Pow(newCostFactor, amount);
    }
}
