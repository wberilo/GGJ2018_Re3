using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEntity : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Person")
        {
            Destroy(collision.gameObject);
        }
    }
}
