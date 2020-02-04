using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class DontDestroyOnAwake : MonoBehaviour
{
   void Awake()
    {

        DontDestroyOnLoad(this.gameObject);
    }
}
