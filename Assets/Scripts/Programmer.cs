using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programmer : MonoBehaviour
{
    public int numOfProgrammers;
    public GameObject[] Programmers;
    Pickup pickup;
    // Start is called before the first frame update
    void Start()
    {
        Programmers = new GameObject[numOfProgrammers];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < numOfProgrammers; i++)
        {
            pickup = GetComponent<Pickup>();
        }
    }
}
