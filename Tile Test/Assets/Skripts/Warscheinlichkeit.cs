using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Warscheinlichkeit : MonoBehaviour
{
    int Zufallsgenerator100;
    int WarscheinlichkeitSchuss;
    public bool Getroffen;
    [SerializeField]
    public Text WarscheinlichkeitsText;
private void Start() {
    
    WarscheinlichkeitSchuss = 100;
}
    private void Update() {
        ObGetroffen();
        Ducken();
        SetWarscheinlichkeitsText();
        
    }
    private void ObGetroffen(){
    if(Input.GetButtonDown("Fire1")){
        Zufallsgenerator100 = Random.Range(1,100);
        
     if(WarscheinlichkeitSchuss >= Zufallsgenerator100){
         Debug.Log("Treffer!");
         Getroffen = true;
     }
     else{
         Debug.Log("Verfehlt!");
         Getroffen = false;
     }}
    }
    private void Ducken(){
        if(Input.GetKeyDown(KeyCode.Y)){
            WarscheinlichkeitSchuss = WarscheinlichkeitSchuss - 10;
    }
    }
    public void SetWarscheinlichkeitsText(){

       WarscheinlichkeitsText.text = "Warscheinlichkeit: " + WarscheinlichkeitSchuss.ToString();
    }
}
