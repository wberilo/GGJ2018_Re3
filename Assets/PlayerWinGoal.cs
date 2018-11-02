using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWinGoal : MonoBehaviour {
    public FroggerManager fg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Alguma coisa plmd");
        if (collision.tag == "PlayerFrog")
        {
            fg.Win();
            Debug.Log("PLAYER VENCEU FROG");
        }
        Debug.Log("aeeeeee");

    }
}
