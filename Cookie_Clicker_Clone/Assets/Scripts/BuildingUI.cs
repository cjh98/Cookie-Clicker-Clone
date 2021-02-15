using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    Building building;

    public Text buildingName;
    public Text amountDisplay;
    public Text costDisplay;

    void Start()
    {
        building = GetComponent<Building>();
        buildingName.text = building.type;
        costDisplay.text = building.baseCost.ToString();
        amountDisplay.text = building.amount.ToString();
    }

    public void OnClick()
    {
        building.Purchase();

        double cost = System.Math.Round(building.CalcPrice());

        amountDisplay.text = building.amount.ToString();
        costDisplay.text = cost.ToString();
    }
}
