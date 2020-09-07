using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paper : MonoBehaviour
{
    // Start is called before the first frame update
    public string level;
    public bool can_read_paper = false;
    public bool is_reading = false;
    public string text;
    public Vector3 pos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(transform.position);
        GameObject Player = GameObject.FindWithTag("Player");
        GameObject ReadText = GameObject.FindWithTag("ReadText");
        var trigger = gameObject.GetComponentInChildren<Trigger>();
        if (Player.GetComponent<PlayerCollision>().near_paper && ReadText.GetComponent<TextRead>().read_text_appeared && trigger.trigger)
        {
            can_read_paper = true;
        }

        if (!trigger.trigger)
        {
            can_read_paper = false;
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x = 0;
            transform.rotation = Quaternion.Euler(rotationVector);
            //transform.position = pos;
            if (is_reading)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.4f, transform.position.z);
                is_reading = false;
            }
            
        }

        if (Input.GetKeyDown("space") && can_read_paper && !is_reading)
        {
            is_reading = true;
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x = 90;
            transform.rotation = Quaternion.Euler(rotationVector);
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.4f, transform.position.z);

        }
    }

    void ChangeTransform()
    {
        if (is_reading)
        {

        }
        else
        {

        }
    }
}
