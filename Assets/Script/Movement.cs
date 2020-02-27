using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
   public GameObject player;
    Vector3 initPos;
    Vector3 gooPos;
    //public Transform hazard;
    public Transform[] bads;
    public AudioClip move;
    public AudioClip nobueno;
    public AudioClip yesbueno;
    public Transform goodies;
    public AudioClip patra;
    int x, z, a, b, c, d, e, f, g, h, j, k, l, m, n, o, p, q, r, s, t, u;

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
        a = Random.Range(3, -4);
        b = Random.Range(3, -4);
        c = Random.Range(3, -4);
        d = Random.Range(3, -4);
        e = Random.Range(3, -4);
        l = Random.Range(3, -4);
        m = Random.Range(3, -4);
        n = Random.Range(3, -4);
        o = Random.Range(3, -4);
        p = Random.Range(3, -4);
        z = Random.Range(0, 7);
        f = Random.Range(0, 7);
        g = Random.Range(0, 7);
        h = Random.Range(0, 7);
        j = Random.Range(0, 7);
        k = Random.Range(0, 7);
        q = Random.Range(0, 7);
        r = Random.Range(0, 7);
        s = Random.Range(0, 7);
        t = Random.Range(0, 7);
        u = Random.Range(0, 7);
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
        /*if (hazard.position == player.transform.position)
        {
            player.transform.position = initPos;
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(nobueno);
            Health.Instance.health -= 1;

        }*/
        if (goodies.position == player.transform.position)
        {
            ScoreScript.scoreValue += 100;
            player.transform.position = initPos;
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(yesbueno);
            goodies.position = new Vector3(x, 1, z);
            bads[0].position = new Vector3(a, 1, f);
            bads[1].position = new Vector3(b, 1, g);
            bads[2].position = new Vector3(c, 1, h);
            bads[3].position = new Vector3(d, 1, j);
            bads[4].position = new Vector3(e, 1, k);
            bads[5].position = new Vector3(l, 1, q);
            bads[6].position = new Vector3(m, 1, r);
            bads[7].position = new Vector3(n, 1, s);
            bads[8].position = new Vector3(o, 1, t);
            bads[9].position = new Vector3(p, 1, u);

        }
        if (ScoreScript.scoreValue == 1000)
        {
            ScoreScript.scoreValue = 0;
            FindObjectOfType<GameManager>().Winner();
            SceneManager.LoadScene("Win");
        }
        
        if (player.transform.position.z > 7) 
        {
            player.transform.position = initPos;
        }
        
        if (player.transform.position.z < 0)
        {
            player.transform.position = initPos;
        }
        
        if (player.transform.position.x > 3)
        {
            player.transform.position = initPos;
        }
        
        if (player.transform.position.x < -4)
        {
            player.transform.position = initPos;
        }

        for (int i = 0; i < bads.Length; i++)
        {
            if (bads[i].position == player.transform.position)
            {
                player.transform.position = initPos;
                AudioSource audio = GetComponent<AudioSource>();
                audio.PlayOneShot(nobueno);
                Health.Instance.health -= 1;
            }
        }
            if (Health.Instance.health == 0)
            {
                FindObjectOfType<GameManager>().GameOver();
                ScoreScript.scoreValue = 0;
            }
        }
    }

