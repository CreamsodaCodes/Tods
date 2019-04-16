using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
   int HP;
   public Text HPcount;

   private void Start() {
     HP = 8;
     SetCountText ();
   }
   private void FixedUpdate() {
     SetCountText();
   }

   void SetCountText()
	{
		
		HPcount.text = "Count: " + HP.ToString();
  }






















}    






