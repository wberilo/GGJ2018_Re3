using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FroggerManager : MonoBehaviour {
    public Hackarea hk;
	// Use this for initialization
	void Start () {
		
	}
	public void Death()
    {
        GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().SetPos(GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().posInicial);
        GameObject.FindGameObjectWithTag("GameGen").GetComponent<GameGen>().HackDeactiv();
        Destroy(GameObject.FindGameObjectWithTag("FroggerManager"));
    }
    public void Win()
    {
        GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().SetPos(GameObject.FindGameObjectWithTag("PlayerFrog").GetComponent<FroggerPlayer>().posInicial);
        GameObject.FindGameObjectWithTag("GameGen").GetComponent<GameGen>().HackDeactiv();
        GameObject.FindGameObjectWithTag("GameGen").GetComponent<GameGen>().predcurHack.Hack();
        Destroy(GameObject.FindGameObjectWithTag("FroggerManager"));
    }
	// Update is called once per frame
	void Update () {
		
	}
}
