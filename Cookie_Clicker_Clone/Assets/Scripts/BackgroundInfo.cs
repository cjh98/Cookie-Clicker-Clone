using UnityEngine;
using TMPro;

public class BackgroundInfo : MonoBehaviour
{
    public TextMeshProUGUI numCookies;
    public TextMeshProUGUI cps;

    string cookiesText;

    void Update()
    {
        int cookies = (int)Game.currentCookies;

        if (cookies == 1)
            cookiesText = " cookie";
        else
            cookiesText = " cookies";

        numCookies.text = cookies + cookiesText;
        cps.text = Game.totalCookiesPerSecond + " per second";
    }
}
