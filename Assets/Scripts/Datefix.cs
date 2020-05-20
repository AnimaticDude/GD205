using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace GT
{//SCRIPT NOT USED
    public class Datefix : MonoBehaviour
    {
        Animator myAnim;
        private NavMeshAgent Mob;

        public GameObject[] Player;
        AudioSource audios;
        public AudioClip hits;
        public AudioClip death;
        public AudioClip slash;

        public Animator animator;





        public float MobDistanceRun = 4.0f;
        void Start()
        {
            Mob = GetComponent<NavMeshAgent>();
            myAnim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < Player.Length; i++){
                float distance = Vector3.Distance(transform.position, Player[i].transform.position);

                if (distance > MobDistanceRun)
                {
                    Mob.velocity = Vector3.zero;
                }

                if (distance < MobDistanceRun)
                {

                    Vector3 dirToPlayer = transform.position - Player[i].transform.position;

                    Vector3 newPos = transform.position - dirToPlayer;

                    Mob.SetDestination(newPos);
                    animator.SetTrigger("Walk");


                    if (Vector3.Distance(Player[i].transform.position, transform.position) <= 1.5f)
                    {

                        animator.SetTrigger("Date");
                        Mob.velocity = Vector3.zero;

                    }
                }
                else
                {
                    animator.SetTrigger("Dance");
                }
            }
        }
    }
}