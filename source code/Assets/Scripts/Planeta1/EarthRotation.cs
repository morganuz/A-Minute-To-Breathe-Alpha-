using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
public int rotateX,rotateY,rotateZ;
void Update()
{
 
  transform.Rotate(new Vector3(rotateX,rotateY,rotateZ) * Time.deltaTime); 
 
}
}
