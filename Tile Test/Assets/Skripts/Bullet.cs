using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{   
    Controller BulletController;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        Debug.Log(BulletController.Leben);
        
    }
    void OnTriggerStay2D(Collider2D LOL)
    {
        Debug.Log(LOL.name);
        Destroy(gameObject);
    }
        

   
}
