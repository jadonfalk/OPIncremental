using UnityEngine;

[System.Serializable]
public class Upgrade
{
    public string name;
    public int level;
    public float baseCost;
    public float costMultiplier;

    public float GetCost()
    {
        return baseCost * Mathf.Pow(costMultiplier, level);
    }
}