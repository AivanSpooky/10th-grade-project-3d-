using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class TextRead : MonoBehaviour
{
    // Start is called before the first frame update
    public int left_angle = 0;
    public int right_angle = 360;
    public bool read_text_appeared = false; 
    public Text image;
    void Start()
    {
        image = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.FindWithTag("Player");
        if (Player.GetComponent<PlayerCollision>().near_paper && Player.transform.eulerAngles.y > left_angle && Player.transform.eulerAngles.y < right_angle)
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            read_text_appeared = true;
        }
        else
        {
            var tempColor = image.color;
            tempColor.a = 0f;
            image.color = tempColor;
            read_text_appeared = false;
        }

    }
}
