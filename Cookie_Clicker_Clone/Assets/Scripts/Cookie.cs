using UnityEngine;

public class Cookie : MonoBehaviour
{
    public Animator animator;

    public GameObject numPrefab;
    public Camera cam;

    public double cookiesPerClick = 1;

    public void OnClickBakeCookies()
    {
        Game.thisGame.currentCookies += cookiesPerClick;
        animator.Play("Spring", -1, 0f);

        Instantiate(numPrefab, Input.mousePosition, Quaternion.identity, transform);
    }
}
