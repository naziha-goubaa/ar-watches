using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
  public GameObject[] watches;
  private int currentwatch = 0;

  public void nextWatch(){
    for(int i=0; i< watches.Length; i++){
      watches[i].gameObject.SetActive(false);
    }
    currentwatch++;
    if (currentwatch == watches.Length){
          currentwatch = 0;
        }
    watches[currentwatch].gameObject.SetActive(true);
  }

  public void backWatch(){
    for(int i=0; i< watches.Length; i++){
      watches[i].gameObject.SetActive(false);
    }
    currentwatch--;
    if (currentwatch == -1){
          currentwatch = watches.Length-1;
        }
    watches[currentwatch].gameObject.SetActive(true);
  }
}
