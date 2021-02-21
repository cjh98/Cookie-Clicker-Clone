using UnityEngine;
using TMPro;

public class CookieClickFX : MonoBehaviour
{
    Cookie cookie;

    public Vector2 speed;
    public Vector2 acceleration;

    public TextMeshProUGUI text;

    public float life;
    public float alphaLoss;

    void Start()
    {
        cookie = FindObjectOfType<Cookie>();
        text.text = string.Format("{0:n0}", cookie.cookiesPerClick);

        Destroy(gameObject, life);
    }

    void FixedUpdate()
    {
        transform.Translate(speed);
        speed += acceleration;

        text.alpha -= alphaLoss;
    }
}
