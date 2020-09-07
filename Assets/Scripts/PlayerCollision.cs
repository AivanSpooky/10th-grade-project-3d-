using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public bool near_door = false;
    public bool near_paper = false;
    void Start()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Door")
        {
            near_door = true;
        }

        if (col.tag == "Paper")
        {
            near_paper = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Door")
        {
            near_door = false;
        }

        if (col.tag == "Paper")
        {
            near_paper = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
