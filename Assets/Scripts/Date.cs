using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date : MonoBehaviour
{
    public GameObject npc1;
    public float TargetDistance = 2;
    public float AllowedDistance = 1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npc5;
    public GameObject npc6;
    public GameObject npc7;
    public GameObject npc8;
    public float FollowSpeed;
    public RaycastHit Shot;
    public float distance;

    Pickup pickup;

    Animator animator;
    // Update is called once per frame

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        npc1 = this.gameObject;
        First();
        Second();
        Third();
        Forth();
        Fifth();
        Sixth();
        Seventh();

        if(distance <= AllowedDistance)
        {
            this.enabled = false; //disables this script
        }
        
    }

    void First()
    {//assignment of programmer pickup by order
        distance = Vector3.Distance(transform.position, npc2.transform.position);
        if (distance > 3)//measure distance between programmers

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk"); //animation for walking
                FollowSpeed = 0.08f; //speed for walking
                transform.LookAt(npc2.transform); //look at target in range
                transform.position = Vector3.MoveTowards(transform.position, npc2.transform.position, FollowSpeed); //wank towards target
            }
            else
            {
                FollowSpeed = 0; //nullify walk if close enough or outside range
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date"); //date animation
            npc2 = null; //disengage target once close enough
            DateCount.scoreValue += 1; //add point to counter
            this.enabled = false; //disable this script
        }
    }
    //all funtions below have the same logic as void first
    void Second()
    {
        distance = Vector3.Distance(transform.position, npc3.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc3.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc3.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc3 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }

    void Third()
    {
        distance = Vector3.Distance(transform.position, npc4.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc4.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc4.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc4 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }

    void Forth()
    {
        distance = Vector3.Distance(transform.position, npc5.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc5.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc5.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc5 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }

    void Fifth()
    {
        distance = Vector3.Distance(transform.position, npc6.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc6.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc6.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc6 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }

    void Sixth()
    {
        distance = Vector3.Distance(transform.position, npc7.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc7.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc7.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc7 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }

    void Seventh()
    {
        distance = Vector3.Distance(transform.position, npc8.transform.position);
        if (distance > 3)

            if (distance <= TargetDistance && distance > AllowedDistance)
            {
                animator.SetTrigger("Walk");
                FollowSpeed = 0.08f;
                transform.LookAt(npc8.transform);
                transform.position = Vector3.MoveTowards(transform.position, npc8.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
            }

        if (distance <= AllowedDistance)
        {
            animator.SetTrigger("Date");
            npc8 = null;
            DateCount.scoreValue += 1;
            this.enabled = false;
        }
    }
}