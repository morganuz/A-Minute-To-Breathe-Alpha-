using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager4 : MonoBehaviour
{
    public AudioMixer myAudioMixer;
    
    int numberOfWords = 2;
    public GameObject completeLevel;
    public float timeOfAnimation,timeofFade;
    
    
    
    
    void LevelEnd(){
        if (numberOfWords == Drop.wordsCompleted)
        {
           
           timeOfAnimation -= Time.deltaTime;
           timeofFade -= Time.deltaTime;
           if(timeofFade <= 0)
           {
               completeLevel.SetActive(true);
               }
          

            if (timeOfAnimation <= 0 )
            {                
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
        }
    }
    
    
    void Awake()
    {
        
                    StartCoroutine(FadeMixerGroup.StartFade(myAudioMixer,"StringsVolume", 30f, 1f));

        
    }
    
    void Start()
    {
        
        timeOfAnimation = 4f;
    }
    
    void Update(){
        LevelEnd();
    }

    
}

