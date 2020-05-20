using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pickup : MonoBehaviour
{
    public Transform dest;
    public float shootForce = 20f;
    public Camera cam;
    Date date;
    AudioSource au;
    public AudioClip pick;
    public AudioClip shot;
    void Start()
    {
        date = GetComponent<Date>(); //get date script in this script
        au = GetComponent<AudioSource>(); //get audio source
    }

    void Update()
    {
        if (date.enabled == false)
        {
            this.enabled = false; //disables this script if date script is disabled to not pickup target after date has been set
        }
    }

    void OnMouseDown()
    {
        if (!enabled)//does not run if script is disabled
            return;
        
        float distance = Vector3.Distance(transform.position, dest.position); //distance between pickup location and target location 

        if (distance >= 3)//allowed distance for pickup
            return;
        au.volume = 0.60f; //audio volume adjustment
        au.PlayOneShot(pick); //play audio for pickup
        GetComponent<BoxCollider>().enabled = false; //disables collider
        GetComponent<Rigidbody>().useGravity = false; //disables rigidbody
        this.transform.position = dest.position; //target moves to this position
        this.transform.parent = GameObject.Find("Destination").transform; //finds position for target in game object
    }

    void OnMouseUp()
    {
        if (!enabled)//does not run if script is disabled
            return;

        float distance = Vector3.Distance(transform.position, dest.position);
        
        if (distance >= 3)
            return;
        //enabled everything that was disabled on mouse click
        au.volume = 0.45f; //audio volume adjustment
        au.PlayOneShot(shot); //play audio for throw
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<BoxCollider>().enabled = true;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = cam.transform.forward * shootForce;
    }
}
