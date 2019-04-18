using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GegenspielerController : MonoBehaviour
{   
    
    private Vector2 direction;
    private Vector2 Playerposition;
    private Vector2 BackToPosition;
    
    Controller TurnSpeicher;
    
    void Start()
    {
        
       TurnSpeicher = GameObject.Find ("Player").GetComponent<Controller> ();
    }

   
    void Update()
    {
        GetInput();
       Move();
       GetInputBack();
    }

     private void Move(){
     transform.Translate(direction*1);
     }

     private void MoveBack(){
     transform.Translate(BackToPosition*1);
   }

   private void GetInput(){

       direction = Vector2.zero;
       if(TurnSpeicher.Player1 == false){
       if(TurnSpeicher.count > 0){
        if(Input.GetKeyDown(KeyCode.W)){
            direction += Vector2.up;
            BackToPosition += Vector2.down;
            TurnSpeicher.count = TurnSpeicher.count - 1;
            TurnSpeicher.SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.A)){
            direction += Vector2.left;
            BackToPosition += Vector2.right;
            TurnSpeicher.count = TurnSpeicher.count - 1;
            TurnSpeicher.SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.S)){
            direction += Vector2.down;
            BackToPosition += Vector2.up;
            TurnSpeicher.count = TurnSpeicher.count - 1;
            TurnSpeicher.SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.D)){
            direction += Vector2.right;
            BackToPosition += Vector2.left;
            TurnSpeicher.count = TurnSpeicher.count - 1;
            TurnSpeicher.SetCountText();
        }
       }}}
        private void GetInputBack(){
        if(TurnSpeicher.Player1 == false){
         if(Input.GetKeyDown(KeyCode.Z))
         {
             MoveBack();
             BackToPosition = Vector2.zero;
             TurnSpeicher.count = 10;
             TurnSpeicher.SetCountText();
         }
         if(Input.GetKeyDown(KeyCode.I))
         {
         BackToPosition = Vector2.zero;
         TurnSpeicher.Player1 = true;
         TurnSpeicher.count = 10;
         TurnSpeicher.SetCountText();
         TurnSpeicher.turn = TurnSpeicher.turn + 1;
         
         TurnSpeicher.SetTurnText();
         }
        }
        
    }



}
