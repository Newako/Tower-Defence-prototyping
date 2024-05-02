using UnityEngine;

public class ShopScript : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileTurret;
    public TurretBlueprint magicTurret;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret ()
    {
        Debug.Log("Standard turret selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileTurret()
    {
        Debug.Log("Missile turret selected");
        buildManager.SelectTurretToBuild(missileTurret);
    }

    public void SelectMagicTurret()
    {
        Debug.Log("Magic tower selected");
        buildManager.SelectTurretToBuild(magicTurret);
    }
}
