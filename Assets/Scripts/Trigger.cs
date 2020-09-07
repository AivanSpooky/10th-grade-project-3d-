using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public bool trigger = false;
    void Start()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            trigger = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            trigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
