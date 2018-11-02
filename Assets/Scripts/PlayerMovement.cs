using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    Animation anim;
    public Animator aAnimVar;
    public Sprite stillSprite;
    public bool isMoving;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (isMoving)
        {
            transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed));
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                aAnimVar.SetBool("Isrunning", true);
                gameObject.transform.localScale = new Vector3(-(20 * Mathf.Sign(Input.GetAxis("Horizontal"))), 20, 20);
            }
            else
            {
                aAnimVar.SetBool("Isrunning", false);
            }
        }
	}
}
