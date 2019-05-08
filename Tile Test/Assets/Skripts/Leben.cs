using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leben : MonoBehaviour
{
    public bool isalivePlayer2;
    public bool isalivePlayer3;
    public bool isalivePlayer1;
    public int Health;
    [SerializeField]
    public Text HealthText;

    public int Health2;
    [SerializeField]
    public Text HealthText2;
    Warscheinlichkeit Getroffen;
    void Start()
    {
        Health = 10;
        SetHealthText();
        SetHealthText2();
        isalivePlayer2 = true;
        isalivePlayer3 = true;
        isalivePlayer1 = true;
        Getroffen = GameObject.Find ("Player").GetComponent<Warscheinlichkeit> ();
    }

    
     public void TakeDamage(int damage)
    {
        if(Getroffen.Getroffen == true){
        Health -= damage;
        SetHealthText();
        SetHealthText2();
    }
        if(Health <= 0)
        {
            Die();
        }
    } 

    void Die(){
        gameObject.SetActive(false);
        if(gameObject.CompareTag("Gegenspieler")){
        isalivePlayer2 = false;
        Debug.Log("funktioniert!");
        }
        else if(gameObject.CompareTag("Player3")){
            isalivePlayer3 = false;
        Debug.Log("funktioniert! Auch bei player 3");
        }
         else if(gameObject.CompareTag("Player1")){
            isalivePlayer1 = false;
        Debug.Log("funktioniert! Auch bei player 1");
        }
    }

    void SetHealthText(){
       HealthText.text = "Player2 life's: " + Health.ToString();
    }
    void SetHealthText2(){
       HealthText.text = "Player3 life's: " + Health.ToString();
    }
}
