using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchKill : MonoBehaviour {
    FroggerManager fg;
    private void Start()
    {
        fg = GameObject.FindGameObjectWithTag("FroggerManager").GetComponent<FroggerManager>();
        Invoke("Destroy", 10f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerFrog")
        {
            Debug.Log("Bati no Playerfrog");
            fg.Death();
        }

    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
