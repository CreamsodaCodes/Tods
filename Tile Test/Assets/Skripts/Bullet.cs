using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{   

    public lebenGegenspieler BulletController;

    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

        
    }
    void OnTriggerStay2D(Collider2D LOL)
    {
        
        Destroy(gameObject);
        Debug.Log(BulletController.leben);
    }
        

   
}
