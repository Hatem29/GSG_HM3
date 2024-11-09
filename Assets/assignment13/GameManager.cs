using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.initializePlayer("Hatem", 100);
        player2.initializePlayer("Amin", 1000);

        player1.heal(50);
        player2.heal(true);

        Player.showPlayerCount();
    }

}
