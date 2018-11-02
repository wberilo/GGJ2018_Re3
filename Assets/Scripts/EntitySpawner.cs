using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawner : MonoBehaviour {
    public float rate;
    public GameObject entity;
    public Vector3 thisDirection;
    public float min, max;
    public Transform parent;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn",rate,rate);
        if(parent!= null)
        {
            parent = transform;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        GameObject spwn = Instantiate(entity, transform.position, Quaternion.identity,parent);
        spwn.GetComponent<Entity>().direction =   new Vector3(Random.Range(min,max)* thisDirection.x, Random.Range(min, max) * thisDirection.y, Random.Range(min, max)* thisDirection.z);
    }

}
