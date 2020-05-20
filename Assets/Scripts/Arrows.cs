using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    Rigidbody myBody;
    private float lifeTimer = 6f;
    private float timer;
    private bool hitSomething = false;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    NPCfollow0 nPCfollow;

    // Start is called before the first frame update
    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.LookRotation(myBody.velocity);
    }

    // Update is called once per frame
    private void Update()
    {

        timer += Time.deltaTime;
        //Destroy arrows after set amount of time
        if (timer >= lifeTimer)
        {
            Destroy(gameObject);
        }
        //Starting rotation of arrows
        if (!hitSomething)
        {
            transform.rotation = Quaternion.LookRotation(myBody.velocity);
        }
    }
    
    void CupidStrike()
    {//layer array to hit programmers... not used
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<NPCfollow0>().TakeDamage();
            
            //nPCfollow.npc2 = this.gameObject;
            //enemy.transform.position = Vector3.MoveTowards(transform.position, NPCfollow0.npc1.transform.position, NPCfollow0.FollowSpeed);
            //enemy.GetComponent<NewBehaviourScript1>().TakeDamage(attackDamage);
        }
    }
    void Cupid2Strike()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<NPCfollow1>().TakeDamage();

            //nPCfollow.npc2 = this.gameObject;
            //enemy.transform.position = Vector3.MoveTowards(transform.position, NPCfollow0.npc1.transform.position, NPCfollow0.FollowSpeed);
            //enemy.GetComponent<NewBehaviourScript1>().TakeDamage(attackDamage);
        }


    }

    void Cupid3Strike()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<NPCfollow2>().TakeDamage();

            //nPCfollow.npc2 = this.gameObject;
            //enemy.transform.position = Vector3.MoveTowards(transform.position, NPCfollow0.npc1.transform.position, NPCfollow0.FollowSpeed);
            //enemy.GetComponent<NewBehaviourScript1>().TakeDamage(attackDamage);
        }
    }

    void Cupid4Strike()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<NPCfollow3>().TakeDamage();

            //nPCfollow.npc2 = this.gameObject;
            //enemy.transform.position = Vector3.MoveTowards(transform.position, NPCfollow0.npc1.transform.position, NPCfollow0.FollowSpeed);
            //enemy.GetComponent<NewBehaviourScript1>().TakeDamage(attackDamage);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {//Not Used... Detection of arrors hitting programmers
        if(collision.collider.tag != "Arrow")
        hitSomething = true;
        Stick();
        if (collision.collider.tag == "Programmer")
        {
            CupidStrike();
        }

        if (collision.collider.tag == "Programmer2")
        {
            Cupid2Strike();
        }

        if (collision.collider.tag == "Programmer3")
        {
            Cupid3Strike();
        }

        if (collision.collider.tag == "Programmer4")
        {
            Cupid4Strike();
        }
    }


    private void Stick()
    {//freeze arrows on contact with object
        myBody.constraints = RigidbodyConstraints.FreezeAll;
    }

    private void OnDrawGizmosSelected()
    {//show attack range
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}