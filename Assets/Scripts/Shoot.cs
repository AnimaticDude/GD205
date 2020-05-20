using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Camera cam;
    public GameObject arrowPrefab;
    public Transform arrowSpawn;
    public float shootForce = 20f;
   

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))//arrow shoot force and direction
        {
            GameObject go = Instantiate(arrowPrefab, arrowSpawn.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();
            rb.velocity = cam.transform.forward * shootForce;
        }   
    }
}
