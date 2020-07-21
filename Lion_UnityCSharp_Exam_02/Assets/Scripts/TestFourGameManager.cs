using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFourGameManager : MonoBehaviour
{
    public GameObject GameOver;
    public TestFourRunner Runner;
    
    void Start()
    {
        Runner.onArrive += ShowGameOver;
    }

    public void ShowGameOver()
    {
        GameOver.SetActive(true);
        Runner.move = false;
        Runner.ani.SetBool("跑步", false);
    }
}
