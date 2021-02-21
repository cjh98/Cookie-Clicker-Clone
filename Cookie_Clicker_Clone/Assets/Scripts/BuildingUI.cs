using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    public int index;

    public Text buildingName;
    public Text price;
    public Text amount;

    void Start()
    {
        buildingName.text = Game.thisGame.buildings[index].type;
        price.text = string.Format("{0:n0}", Game.thisGame.buildings[index].GetPrice());
        amount.text = Game.thisGame.buildings[index].amount.ToString();
    }

    public void OnClick()
    {
        if (Game.thisGame.currentCookies >= Game.thisGame.buildings[index].GetPrice())
        {
            Game.thisGame.buildings[index].Purchase();
        }
        

        price.text = string.Format("{0:n0}", Game.thisGame.buildings[index].GetPrice());
        amount.text = Game.thisGame.buildings[index].amount.ToString();
    }
}
