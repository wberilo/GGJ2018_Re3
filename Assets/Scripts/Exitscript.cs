using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitscript : MonoBehaviour {
    public FroggerManager fg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            fg.Death();
        }
        Debug.Log("aeeeeee");

    }
}
