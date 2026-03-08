using UnityEngine;
using System.Collections.Generic;

public class UpgradeManager : MonoBehaviour
{
    public List<Upgrade> upgrades = new List<Upgrade>();

    void Start()
    {
        upgrades.Add(new Upgrade { name = "Damage", level = 0, baseCost = 10, costMultiplier = 1.5f });
        upgrades.Add(new Upgrade { name = "XP Multiplier", level = 0, baseCost = 20, costMultiplier = 1.7f });
    }
}