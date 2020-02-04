using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    public MeshRenderer PlanetMeshRenderer;
    public Material mat;
    public Material fullbright;
    int numberOfWords = 2;
    
    private Material _material;
  

    void Start()
    {
        _material = PlanetMeshRenderer.material;
        _material.EnableKeyword("_EMISSION");
    } 

    void Update(){
            if (numberOfWords == Drop.wordsCompleted){
                
                
                _material.Lerp(_material,fullbright,Time.deltaTime / 50);
            }
            
           
        }
    }

