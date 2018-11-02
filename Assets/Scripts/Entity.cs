using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {
    public Vector3 direction;
    public bool walk = true;
    public GameGen gam;
    public Animator aAnimVar;
    // Use this for initialization

    // Update is called once per frame
    private void Update()
    {
        if(gameObject.tag== "Person")
        {

            if(direction.x > 0)
            {
               transform.localScale = new Vector3(-20, 20, 20);
            }
            else
            {
               transform.localScale = new Vector3(20, 20, 20);
            }
        }
    }
    void FixedUpdate () {
        if (walk)
        {
            transform.Translate(direction);
        }
	}
    public void StopAndThink()
    {
        Invoke("PauseTime", 1);
    }
    public void PauseTime()
    {
        aAnimVar.SetBool("Parado", true);
        Invoke("ReturnWalk", 6);
        walk = false;
    }
    public void ReturnWalk()
    {
        aAnimVar.SetBool("Blue", true);
        Debug.Log("FUI CONVERTIDO");
        GameObject.FindGameObjectWithTag("GameGen").GetComponent<GameGen>().peopleConverted += 1;
        walk = true;


    }
}
