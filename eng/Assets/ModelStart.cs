using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelStart : MonoBehaviour
{
 public void ChangeModelScene(string HelloAR)
 {
  Application.LoadLevel(HelloAR);
 }
}