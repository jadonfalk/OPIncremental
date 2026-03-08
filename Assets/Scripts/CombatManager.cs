using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public Enemy enemy;
    public ResourceManager resourceManager;

    public float playerDamage = 2f;

    public void AttackEnemy()
    {
        enemy.TakeDamage(playerDamage);

        Debug.Log("Enemy HP: " + enemy.currentHP);

        if (enemy.IsDead())
        {
            Debug.Log("Enemy defeated!");

            // Give rewards
            resourceManager.AddResource("Beli", enemy.beliReward);
            resourceManager.AddResource("XP", enemy.xpReward);
            resourceManager.AddResource("Bounty", enemy.bountyReward);

            enemy.Respawn();
        }
    }
}