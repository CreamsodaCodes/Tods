using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{   


    [SerializeField]
    private float speed;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private int damage = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerStay2D(Collider2D hitInfo)
    {
        Leben enemy = hitInfo.GetComponent<Leben>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
        

   
}
