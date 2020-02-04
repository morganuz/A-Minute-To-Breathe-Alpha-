using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerTitle : MonoBehaviour
{
    public float tiempoDePasaje;
    void LevelEnd(){
    

            tiempoDePasaje -= Time.deltaTime;
            if (tiempoDePasaje<= 0 ){                
                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

    }
    void Start()
    {
        tiempoDePasaje = 4f;
    }
    void Update()
    {
        LevelEnd();
    }
}
