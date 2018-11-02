using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameGen : MonoBehaviour {
    public int peopleConverted;

    public bool hacking;

    GameObject player;

    public GameObject telaHack;
    public GameObject froggerAreaPrefab;
    public GameObject thisHackArea;
    public Hackarea predcurHack;

    bool frogExists = false;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        if (peopleConverted > 400)
        {
            SceneManager.LoadScene("final");
        }
        if (hacking)
        {

            HackActiv();
        }
        else
        {
            HackDeactiv();
        }
	}
    void SpwnNewHckArea()
    {

        thisHackArea = Instantiate(froggerAreaPrefab,transform.position, Quaternion.identity);
        frogExists = true;
    }
    public void HackActiv()
    {
        if(frogExists == false)
        {
            SpwnNewHckArea();
        }
        telaHack.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isMoving = false;
        player.GetComponent<Animator>().SetBool("ishacking", true);
        GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().isFMoving = true;
    }
    public void HackDeactiv()
    {
        frogExists = false;
        hacking = false;
        telaHack.SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isMoving = true;
        player.GetComponent<Animator>().SetBool("ishacking", false);
        //GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().isFMoving = false;
    }
}
