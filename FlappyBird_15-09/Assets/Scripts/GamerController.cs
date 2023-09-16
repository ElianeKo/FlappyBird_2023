using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamerController : MonoBehaviour
{
    public int Score;
    public Text scoreText;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
       SceneManager.LoadScene(0);
    }


}
