using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanagerepilogue : MonoBehaviour
{
    public float timeforTransition;
    
    
    void Awake(){
        
    }
    
    
    void Update(){
        
        timeforTransition -= Time.deltaTime;
        if(timeforTransition <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
