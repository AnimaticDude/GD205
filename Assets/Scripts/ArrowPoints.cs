using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Not Used
public class ArrowPoints : MonoBehaviour
{
    private void OnTriggerEnter(Collision col)
    {
       switch (col.gameObject.tag)
        {
            case "Programmer1":
                break;
            case "Programmer2":
                break;
        } 
    }
}
