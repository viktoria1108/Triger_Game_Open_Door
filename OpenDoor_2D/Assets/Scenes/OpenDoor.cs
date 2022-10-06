using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject Door;
    bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        if (!isOpened)
        {
            isOpened = true;
            Door.transform.position += new Vector3(-4, 0, 0);
           
        }
       
    }
   
}
