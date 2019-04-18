using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SichtfeldPlayer1 : MonoBehaviour
{
    int call;
    // Start is called before the first frame update
    void Start()
    {
        call = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D Si){
        if (Si.gameObject.CompareTag("Sichtfeld")){
        if(Input.GetKey(KeyCode.Q)){
          
          Si.gameObject.SetActive(true);
      }
      else{
          Si.gameObject.SetActive(false);
          Debug.Log(call);
      }
      }
    }
}
