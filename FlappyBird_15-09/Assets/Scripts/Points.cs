using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GamerController controller;

     void Start()
    {
        controller = FindObjectOfType<GamerController>();
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }

   
}
