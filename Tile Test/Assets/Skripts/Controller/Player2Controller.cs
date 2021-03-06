﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{   
    
    private Vector2 direction;
    private Vector2 Playerposition;
    private Vector2 BackToPosition;
    private bool Aktion1;
    Leben lifeTester;
    
    Player1Controller TurnSpeicher;
    
    void Start()
    {
       lifeTester = GameObject.Find ("Gegenspieler").GetComponent<Leben> ();
       TurnSpeicher = GameObject.Find ("Player").GetComponent<Player1Controller> ();
       Aktion1 = true;
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
       if(TurnSpeicher.welcherSpieler == "Player2"){
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
        if(TurnSpeicher.welcherSpieler == "Player2"){
         if(Input.GetKeyDown(KeyCode.Z))
         {
             MoveBack();
             BackToPosition = Vector2.zero;
             TurnSpeicher.count = 3;
             TurnSpeicher.SetCountText();
         }
         if(Input.GetKeyDown(KeyCode.I))
         {
         BackToPosition = Vector2.zero;
         
         
         TurnSpeicher.count = 3;
         TurnSpeicher.SetCountText();
         if(Aktion1 == false){
             Aktion1 = true;
           if(lifeTester.isalivePlayer3 == true){
                TurnSpeicher.welcherSpieler = "Player3";
                Debug.Log("am Leben");
                TurnSpeicher.turn = TurnSpeicher.turn + 1;
                
                TurnSpeicher.SetTurnText();
            }
            else
            {
                TurnSpeicher.welcherSpieler = "Player1";
                Debug.Log("Nicht am Leben");
                TurnSpeicher.turn = TurnSpeicher.turn + 1;
                
                TurnSpeicher.SetTurnText();
            }
         }
         else{
             Aktion1 = false;
         }
         
         
         }
        }
        
    }


    void OnTriggerStay2D(Collider2D other){
        if (other.gameObject.CompareTag ("Top")){
            TurnSpeicher.count = TurnSpeicher.count + 1;
            TurnSpeicher.SetCountText();
            direction += Vector2.down;
            BackToPosition += Vector2.up;
            Move();
        }
        else if (other.gameObject.CompareTag ("Left")){
            TurnSpeicher.count = TurnSpeicher.count + 1;
            TurnSpeicher.SetCountText();
            direction += Vector2.right;
            BackToPosition += Vector2.left;
            Move();
        }
         else if (other.gameObject.CompareTag ("Right")){
            TurnSpeicher.count = TurnSpeicher.count + 1;
            TurnSpeicher.SetCountText();
            direction += Vector2.left;
            BackToPosition += Vector2.right;
            Move();
        }
         else if (other.gameObject.CompareTag ("Bottom")){
            TurnSpeicher.count = TurnSpeicher.count + 1;
            TurnSpeicher.SetCountText();
            direction += Vector2.up;
            BackToPosition += Vector2.down;

            Move();
        }
        } 



}
