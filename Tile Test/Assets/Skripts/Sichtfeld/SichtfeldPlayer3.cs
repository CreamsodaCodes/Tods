using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SichtfeldPlayer3 : MonoBehaviour
{
     int call;
    private SpriteRenderer mySichtfeld;
    private BoxCollider2D myHitBox;
    Controller TurnSpeicher;
    
    // Start is called before the first frame update
    void Start()
    {
        call = 10;
        mySichtfeld = GetComponent<SpriteRenderer>();
        myHitBox = GetComponent<BoxCollider2D>();
        TurnSpeicher = GameObject.Find ("Player").GetComponent<Controller> ();
        mySichtfeld.enabled = !mySichtfeld.enabled;
        myHitBox.enabled = !myHitBox.enabled;

    }

    // Update is called once per frame
    void Update()
    {
        if(TurnSpeicher.welcherSpieler == "Player3"){
        SichtfeldAkttivator();
        }
        else{
            myHitBox.enabled = false;
            mySichtfeld.enabled = false;
        }
    }
   void SichtfeldAkttivator(){
       if(Input.GetKeyDown(KeyCode.Q)){
            mySichtfeld.enabled = !mySichtfeld.enabled;
            myHitBox.enabled = !myHitBox.enabled;
        }
   }
}
