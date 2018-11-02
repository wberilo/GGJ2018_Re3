using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hackarea : MonoBehaviour {
    //public SpriteRenderer[] afetados;

    public GameObject spriteHolder;
    public Sprite spriteNormal;
    public Sprite spriteMudado;

    public bool converted = false;
    GameGen gam;
    
    bool isPlayerin = false;

    private void Start()
    {
        spriteHolder.GetComponent<SpriteRenderer>().sprite = spriteNormal;
        gam = GameObject.FindGameObjectWithTag("GameGen").GetComponent<GameGen>();
        
    }
    private void Update()
    {
        if(isPlayerin == true)
        {
            GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().enabled = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Text").GetComponent<Text>().enabled = true;
        }
        if (isPlayerin && converted == false && GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isMoving == true)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.H))
            {
                
                Debug.Log("Hacking");
                gam.hacking = true;
                gam.predcurHack = this;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //People converting
        Debug.Log("Object entered zone");
        if (converted == true)
        {
            
            if (collision.tag == "Person")
            {
                Debug.Log("Person entered zone");
                float a = Random.Range(0f, 1f);
                if (a > 0.5f)
                {
                    collision.GetComponent<Entity>().StopAndThink();
                }
            }
        }
        //Hacking
        if (converted == false)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("Player Entered Zone");
                isPlayerin = true;
                
            }
        }
    }
    public void Hack()
    {
        spriteHolder.GetComponent<SpriteRenderer>().sprite = spriteMudado;
        Debug.Log("Hacked Successfully");
        converted = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Player Exited Zone");
            gam.hacking = false;
            isPlayerin = false;
            
        }
    }
}
