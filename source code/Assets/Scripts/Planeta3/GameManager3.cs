using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager3 : MonoBehaviour
{
   
    
    int numberOfWords = 2;
    public GameObject completeLevel;
    public float timeOfAnimation = 45000f;
    
    void LevelEnd(){
        if (numberOfWords == Drop.wordsCompleted)
        {
           
           timeOfAnimation -= Time.deltaTime;
           completeLevel.SetActive(true);

            if (timeOfAnimation <= 0 ){                
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

                }

    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        timeOfAnimation = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        
        LevelEnd();
    }
   


}
    
    




