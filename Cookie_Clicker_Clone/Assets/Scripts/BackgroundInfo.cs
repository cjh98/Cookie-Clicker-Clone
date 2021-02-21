using UnityEngine;
using TMPro;

public class BackgroundInfo : MonoBehaviour
{
    public TextMeshProUGUI numCookies;
    public TextMeshProUGUI cps;

    string cookiesText;

    void Update()
    {

        double cookies = System.Math.Round(Game.thisGame.currentCookies); ;

        if (cookies == 1)
            cookiesText = " cookie";
        else
            cookiesText = " cookies";

        numCookies.text = string.Format("{0:n0}", cookies) + cookiesText;
        cps.text = string.Format("{0:0.#}", Game.thisGame.totalCookiesPerSecond) + " per second";
    }
}
