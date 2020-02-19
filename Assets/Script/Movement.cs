using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public GameObject player;
    Vector3 initPos;
    Vector3 gooPos;
    public Transform hazard;
    public Transform[] bads;
    public AudioClip move;
    public AudioClip nobueno;
    public AudioClip yesbueno;
    public Transform goodies;
    public AudioClip patra;
    int x;
    int z;
    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;
        gooPos = goodies.transform.position;
        //bads = new Transform[9];
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(3, -4);
        z = Random.Range(0, 7);
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position += new Vector3(0, 0, -1);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position += new Vector3(0, 0, 1);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += new Vector3(1, 0, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += new Vector3(-1, 0, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            player.transform.position += new Vector3(0, 1, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.transform.position += new Vector3(0, -1, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(move);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.transform.position = new Vector3(3, 1, 7);
            goodies.transform.position = new Vector3(-4, 1, 0);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(patra);
        }
        if (hazard.position == player.transform.position)
        {
            player.transform.position = initPos;
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(nobueno);

        }
        if (goodies.position == player.transform.position)
        {
            player.transform.position = initPos;
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(yesbueno);
            goodies.position = new Vector3(x, 1, z);
        }

        for (int i = 0; i < bads.Length; i++)
        {
            if (bads[i].position == player.transform.position)
            {
                player.transform.position = initPos;
                AudioSource audio = GetComponent<AudioSource>();
                audio.PlayOneShot(nobueno);

            }
        }
    }
}
