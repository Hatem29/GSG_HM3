
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    private int initialHealth = 100;
    static int playerCount = 0;

    public void initializePlayer(string name, int initialHealth)
    {
        this.playerName = name;
        this.health = initialHealth;
        this.initialHealth = initialHealth;
        playerCount++;
    }

    public void heal(int amount)
    {
        this.health += amount;
        
        Debug.Log("Healed. Health : " +  this.health);
    }

    public void heal(bool fullRestore)
    {
        if (fullRestore)
        {
            if (this.health < initialHealth)
            {
                this.health = initialHealth;
                Debug.Log("Health fully restored!");
            }
            Debug.Log("Health is already full.");
        }
    }

    public static void showPlayerCount()
    {
        Debug.Log("Player count : " +  playerCount);
    }
}
