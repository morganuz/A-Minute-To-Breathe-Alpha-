using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class GameManagerImage1 : MonoBehaviour
{
   public AudioMixer myAudioMixer;
   float tiempoDeTransicion;
   
   void Awake()
    {
        
         StartCoroutine(FadeMixerGroup.StartFade(myAudioMixer,"PianoVolume", 30f, 1f));

        
    }
    
    void Start(){
        
        
        tiempoDeTransicion = 12f;
    }
    void Update()
    {
        
        tiempoDeTransicion -= Time.deltaTime;
        if (tiempoDeTransicion <= 0){
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
