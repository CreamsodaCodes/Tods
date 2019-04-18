using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField]
    public lebenGegenspieler lifeController;
    [SerializeField]  
    public Text countText;
    [SerializeField]
    public Text turnText;
    private bool Aktion1;
    public string welcherSpieler;
    private Vector2 direction;
    private Vector2 Playerposition;
    private Vector2 BackToPosition;
    public int count;
    public int turn;

	/*void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag ("Base")){
            count = count + 1;
            SetCountText();
            direction += Vector2.down;
            Move();
        }
        } */	
  void OnTriggerStay2D(Collider2D other){
        if (other.gameObject.CompareTag ("Top")){
            count = count + 1;
            SetCountText();
            direction += Vector2.down;
            BackToPosition += Vector2.up;
            Move();
        }
        else if (other.gameObject.CompareTag ("Left")){
            count = count + 1;
            SetCountText();
            direction += Vector2.right;
            BackToPosition += Vector2.left;
            Move();
        }
         else if (other.gameObject.CompareTag ("Right")){
            count = count + 1;
            SetCountText();
            direction += Vector2.left;
            BackToPosition += Vector2.right;
            Move();
        }
         else if (other.gameObject.CompareTag ("Bottom")){
            count = count + 1;
            SetCountText();
            direction += Vector2.up;
            BackToPosition += Vector2.down;

            Move();
        }
        } 

    void Start(){
        //Player1 = true;
        welcherSpieler = "Player1";
        count = 3;
        SetCountText(); 
        turn = 0;   
        SetTurnText();
        Aktion1 = true;
    }
    void Update() {
        
       GetInput();
       Move();
       GetInputBack();
       inputShot();
   }

   private void Move(){
     transform.Translate(direction *1 );
     /*tarnsform = das menu oben links bei unity... Translate heißt glaub umwandeln oder so... direction ist die funktion in der wir die richtung bestimmen in dem wir nem vector + richtung rechnen und 
     dann * 1 für 1 feld in die richtung  */

   }
   private void MoveBack(){
     transform.Translate(BackToPosition * 1);
   }


   private void GetInput(){

       direction = Vector2.zero;
       /* ohne des Zero wird des immer mehr also wenn man zweimal w drückt dann ist die richtung stärker als davor und wenn man dann einmal s drückt geht es nicht zurück also wie ne zahl die aber in vier richtungen 
       geht vlht x u nd y mit - und + */
      if(welcherSpieler == "Player1"){
       if(count > 0){
        if(Input.GetKeyDown(KeyCode.W)){
            direction += Vector2.up;
            BackToPosition += Vector2.down;
            count = count - 1;
            SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.A)){
            direction += Vector2.left;
            BackToPosition += Vector2.right;
            count = count - 1;
            SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.S)){
            direction += Vector2.down;
            BackToPosition += Vector2.up;
            count = count - 1;
            SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.D)){
            direction += Vector2.right;
            BackToPosition += Vector2.left;
            count = count - 1;
            SetCountText();
        }
        }
      }
   }
         
       
       
       
       
   
   public void SetTurnText(){
       turnText.text = "Turns: " + turn.ToString();
    }

   public void SetCountText(){
       countText.text = "Remaining Steps: " + count.ToString();
    }
    /* count.ToString = irgendeine variable zu dem Text */
    private void GetInputBack(){
      if(welcherSpieler == "Player1"){
        if(Input.GetKeyDown(KeyCode.Z))
        {
            MoveBack();
            BackToPosition = Vector2.zero;
            count = 3;
            SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
          BackToPosition = Vector2.zero;
          
          count = 3;
          SetCountText();
     if(Aktion1 == false){
           Aktion1 = true;
           welcherSpieler = "Player2";

           turn = turn + 1;
          
           SetTurnText();
           
          }
        else
        {
         Aktion1 = false;
        }
        }
        
      
      }
    }
    void inputShot(){
        if(Input.GetKeyDown(KeyCode.P))
        {
            lifeController.leben = lifeController.leben - 1;
            lifeController.SetLebenText();
        }
    }
}   
   

