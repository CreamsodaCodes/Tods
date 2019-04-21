using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Warscheinlichkeit : MonoBehaviour
{
    int Zufallsgenerator100;
    int WarscheinlichkeitSchuss;
private void Start() {
    Zufallsgenerator100 = Random.Range(1,100);
    WarscheinlichkeitSchuss = 100;
}
    private void Update() {
        ObGetroffen();
    }
    private void ObGetroffen(){
     if(WarscheinlichkeitSchuss >= Zufallsgenerator100){
         Debug.Log("Treffer!");
     }
     else{
         Debug.Log("Verfehlt!");
     }
    }
}
