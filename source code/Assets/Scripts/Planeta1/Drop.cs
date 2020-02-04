using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class Drop : MonoBehaviour, IDropHandler
{
    public static int wordsCompleted;
    
    void Start(){
        wordsCompleted = 0;
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        wordsCompleted += 1;
        Debug.Log(wordsCompleted);
    }
}
