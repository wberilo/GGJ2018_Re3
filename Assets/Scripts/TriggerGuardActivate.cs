using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGuardActivate : MonoBehaviour {
    public bool playerVisible = false;
    public Vector3 latestPlayerPosition;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerVisible = true;
            latestPlayerPosition = collision.gameObject.transform.position;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerVisible = false;
            latestPlayerPosition = other.gameObject.transform.position;

        }
    }

}
