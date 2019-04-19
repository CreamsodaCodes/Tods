using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leben : MonoBehaviour
{
    public bool isalivePlayer2;
    public int Health;
    [SerializeField]
    public Text HealthText;

    public int Health2;
    [SerializeField]
    public Text HealthText2;
    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
        SetHealthText();
        SetHealthText2();
        isalivePlayer2 = true;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        Health -= damage;
        SetHealthText();
        SetHealthText2();

        if(Health <= 0)
        {
            Die();
        }
    }

    void Die(){
        gameObject.SetActive(false);
        isalivePlayer2 = false;
        
    }

    void SetHealthText(){
       HealthText.text = "Player2 life's: " + Health.ToString();
    }
    void SetHealthText2(){
       HealthText.text = "Player3 life's: " + Health.ToString();
    }
}
