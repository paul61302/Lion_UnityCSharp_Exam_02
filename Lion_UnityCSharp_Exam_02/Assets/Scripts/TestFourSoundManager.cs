using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFourSoundManager : MonoBehaviour
{
    public TestFourRunner Runner;
    public AudioClip audio1;
    
    // Start is called before the first frame update
    void Start()
    {
        Runner.onArrive += EndGameMusic;
        //audioSource1 = GetComponent<AudioSource>();
    }

    public void EndGameMusic()
    {
        Runner.aud.clip = audio1;
        
    }
}
