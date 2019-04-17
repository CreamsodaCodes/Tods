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
    public bool Player1;
    private Vector2 direction;
    private Vector2 Playerposition;
    private Vector2 BackToPosition;
    private int count;
    public int turn;

    //Braucht Jemand diesen Bool ? Weil ich glaub der ist von dem ersten versuch zu schießen,wenn niemand ihn braucht bitte ihn und den komentar löschen
    private bool isAttacking = false;






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
        Player1 = true;
        count = 10;
        SetCountText(); 
        turn = 0;   
        SetTurnText();
    }
    private void Update() {
        
       GetInput();
       Move();
       GetInputBack();
       if (Input.GetButtonDown("Fire1") && !isAttacking)
           isAttacking = true;
   }

   private void Move(){
     transform.Translate(direction*1);
     /*tarnsform = das menu oben links bei unity... Translate heißt glaub umwandeln oder so... direction ist die funktion in der wir die richtung bestimmen in dem wir nem vector + richtung rechnen und 
     dann * 1 für 1 feld in die richtung  */

   }
   private void MoveBack(){
     transform.Translate(BackToPosition*1);
   }


   private void GetInput(){

       direction = Vector2.zero;
       /* ohne des Zero wird des immer mehr also wenn man zweimal w drückt dann ist die richtung stärker als davor und wenn man dann einmal s drückt geht es nicht zurück also wie ne zahl die aber in vier richtungen 
       geht vlht x u nd y mit - und + */
      if(Player1 == true){
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
        }}
         
       }
       
       
       
   }
   void SetTurnText(){
       turnText.text = "Turns: " + turn.ToString();
    }

   public void SetCountText(){
       countText.text = "Remaining Steps: " + count.ToString();
    }
    /* count.ToString = irgendeine variable zu dem Text */
    private void GetInputBack(){
      if(Player1 == true){
        if(Input.GetKeyDown(KeyCode.Z))
        {
            MoveBack();
            BackToPosition = Vector2.zero;
            count = 10;
            SetCountText();
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
        BackToPosition = Vector2.zero;
        Player1 = false;
        count = 10;
        SetCountText();
        turn = turn + 1;
        
        SetTurnText();
        }
        
      
      }
    }
    void inputShot(){
        if(Input.GetKeyDown(KeyCode.P))
            {
                lifeController.leben = lifeController.leben - 1;
            }
    }
    
   
}
