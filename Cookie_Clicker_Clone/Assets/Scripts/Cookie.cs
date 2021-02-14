using UnityEngine;

public class Cookie : MonoBehaviour
{
    public double cookiesPerClick = 1;

    public void OnClickBakeCookies()
    {
        Game.BakeCookies(cookiesPerClick / Game.timeStep);
    }
}
