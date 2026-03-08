using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    // Dictionary to store different resources
    public Dictionary<string, float> resources = new Dictionary<string, float>();

    void Start()
    {
        // Initialize resources
        resources["Beli"] = 0;
        resources["XP"] = 0;
        resources["Bounty"] = 0;
    }

    // Add resource
    public void AddResource(string type, float amount)
    {
        if (resources.ContainsKey(type))
        {
            resources[type] += amount;
        }
    }

    // Get resource value
    public float GetResource(string type)
    {
        if (resources.ContainsKey(type))
        {
            return resources[type];
        }

        return 0;
    }
}