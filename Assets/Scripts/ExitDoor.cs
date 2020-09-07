using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public string level;
    public bool can_exit = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        GameObject OpenText = GameObject.FindWithTag("OpenText");
        var trigger = gameObject.GetComponentInChildren<Trigger>();
        if (Player.GetComponent<PlayerCollision>().near_door && OpenText.GetComponent<TextOpen>().open_text_appeared && trigger.trigger)
        {
            can_exit = true;
        }
        else
        {
            can_exit = false;
        }

        if (Input.GetKeyDown("space") && can_exit)
        {
            SceneManager.LoadScene("Scenes/Level-" + level);
        }
    }
}
