using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement : MonoBehaviour {
    public TriggerGuardActivate trig;
    public GameObject target;
    public float speed;
    public GameObject[] patrolList;
    //GameObject curPatrolPoint;
    bool patrolActivate = false;
    bool isPatrolling = true;
    int curPatrolnum = 0;
    public float patrolTime;
    public Transform center;
    Animator aAnimVar;

    void Start()
    {
        aAnimVar = GetComponent<Animator>();
        InvokeRepeating("NextPatrolPoint", patrolTime, patrolTime);
    }
    void Update()
    {
        if(patrolActivate == true)
        {
            NextPatrolPoint();
        }
        if (trig.playerVisible == false)
        {
            isPatrolling = true;

        }
        if (trig.playerVisible)
        {
            Debug.Log("PlayerAlert");
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(center.position, target.transform.position, step);
            isPatrolling = false;
            aAnimVar.SetBool("IsRunning", true);
            if(target.transform.position.x > center.position.x)
            {
                gameObject.transform.localScale = new Vector3((-20 ), 20, 20);
            }
            else
            {
                gameObject.transform.localScale = new Vector3((20 * 1), 20, 20);
            }
        }
        else if (isPatrolling && Vector3.Distance(center.position,patrolList[curPatrolnum].transform.position) > 1)
        {
            Debug.Log("Patrolling");
            aAnimVar.SetBool("IsRunning", true);
            float step = speed * Time.deltaTime; 
            transform.position = Vector3.MoveTowards(center.position, patrolList[curPatrolnum].transform.position, step);
            if (patrolList[curPatrolnum].transform.position.x < center.position.x)
            {
                gameObject.transform.localScale = new Vector3((20), 20, 20);
            }
            else
            {
                gameObject.transform.localScale = new Vector3(-(20), 20, 20);
            }
        }
        else
        {
            aAnimVar.SetBool("IsRunning", false);
        }

        
        
    }
    void NextPatrolPoint()
    {
        patrolActivate = false;
        curPatrolnum = curPatrolnum+ 1;
        if(curPatrolnum > patrolList.Length - 1)
        {
            curPatrolnum = 0;
        }
        Debug.Log("Nextpatrol "+curPatrolnum);
    }



}

