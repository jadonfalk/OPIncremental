using UnityEngine;

public class ResourceDisplay : MonoBehaviour
{
    public ResourceManager resourceManager;

    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0;

            Debug.Log(
                "Beli: " + resourceManager.GetResource("Beli") +
                " | XP: " + resourceManager.GetResource("XP") +
                " | Bounty: " + resourceManager.GetResource("Bounty")
            );
        }
    }
}