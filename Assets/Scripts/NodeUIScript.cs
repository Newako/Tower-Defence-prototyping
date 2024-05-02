using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NodeUIScript : MonoBehaviour
{
    public GameObject ui;

    private node target;

    public TMP_Text upgradeCost;
    public Button upgradeButton;

    public TMP_Text sellAmount;

    public void SetTarget(node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        if(!target.isUpgraded)
        {
            upgradeCost.text = "Gold: " + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "FULL";
            upgradeButton.interactable = false;
        }

        sellAmount.text = "G: " + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
}
