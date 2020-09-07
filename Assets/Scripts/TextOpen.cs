using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class TextOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public int left_angle = 140;
    public int right_angle = 240;
    public bool open_text_appeared = false; 
    public Text image;
    void Start()
    {
        image = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        if (Player.GetComponent<PlayerCollision>().near_door && Player.transform.eulerAngles.y > left_angle && Player.transform.eulerAngles.y < right_angle)
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            open_text_appeared = true;
        }
        else
        {
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
            open_text_appeared = false;
        }

    }
}
