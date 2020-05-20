using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCfollow0 : MonoBehaviour
{//SCRIPT NOT USED
    public GameObject npc1;
    public float TargetDistance;
    public float AllowedDistance = 1;
    public GameObject npc2;
    public float FollowSpeed;
    public RaycastHit Shot;

    Animator animator;
    // Update is called once per frame

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        
        transform.LookAt(npc2.transform);

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            //if (npc1 == null)
                //return;
            if (this.tag == ("Love") && npc2.tag == ("Love"))
            {
                if (TargetDistance > AllowedDistance)
                {
                    animator.SetTrigger("Walk");
                    FollowSpeed = 0.08f;
                    transform.position = Vector3.MoveTowards(transform.position, npc2.transform.position, FollowSpeed);
                }
            }
            else
            {
                FollowSpeed = 0;
            }

            if (TargetDistance <= AllowedDistance)
            {
                animator.SetTrigger("Date");
                npc2 = null;
                this.tag = ("Date");
                this.enabled = false;
            }
        }
    }

    public void TakeDamage()
    {
        this.tag = ("Love");

        if (npc2 != null)
            return;
        npc2 = GameObject.FindGameObjectWithTag("Programmer");

        if (npc2 == null)
        {
            npc2 = GameObject.FindGameObjectWithTag("Love");
        }
    }
}
