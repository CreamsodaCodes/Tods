using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lebenGegenspieler : MonoBehaviour
{
    [SerializeField]
    public Text lebenText;
    public int leben;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        leben = 10;
        SetLebenText();
    }

    public void SetLebenText()
    {
       lebenText.text = "Life of GP: " + leben.ToString();
    }
}
