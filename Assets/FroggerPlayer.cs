using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerPlayer : MonoBehaviour {
    public Vector3 posInicial;
    public bool isFMoving;
    public float speed;
	// Use this for initialization
	void Start () {
        posInicial = transform.position;
	}
    public void SetPos(Vector3 pos)
    {
        transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
        if (isFMoving)
        {
            Debug.Log("TOMEXENO");
            transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed));
        }
    }
}
