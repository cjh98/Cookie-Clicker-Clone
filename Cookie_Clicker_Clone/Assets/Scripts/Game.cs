using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game thisGame;

    public List<Building> buildings = new List<Building>()
    {
        {new Building("Cursor",  15,     0.1)},
        {new Building("Grandma", 100,    1  )},
        {new Building("Farm",    1100,   8  )},
        {new Building("Mine",    12000,  47 )},
        {new Building("Factory", 130000, 260)}
    };

    public double timeStep = 0.02;

    public double currentCookies = 0;
    public double totalCookiesPerSecond = 0;

    void Awake()
    {
        thisGame = this;
    }
    public double GetCPS()
    {
        double cps = 0;
        Building current;

        for (int i = 0; i < buildings.Count; i++)
        {
            current = buildings[i];
            cps += current.cookiesPerSecond * current.amount * current.level;
        }

        return cps;
    }

    void FixedUpdate()
    {
        totalCookiesPerSecond = GetCPS();
        currentCookies += totalCookiesPerSecond * timeStep;
    }
}
