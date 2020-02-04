using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class Drag : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
   public void OnBeginDrag (PointerEventData eventData) {
       Debug.Log("OnBeginDrag");
   }

    public void OnDrag(PointerEventData eventData) {
        this.transform.position = eventData.position;
    }

   public void OnEndDrag(PointerEventData eventData){
       Debug.Log("OnEndDrag");
   }

}
