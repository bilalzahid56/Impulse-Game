using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wave : MonoBehaviour
{
   
    [SerializeField] private Rigidbody2D rb;
   [SerializeField] private float speed = 15;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

          //rb.AddForce(Vector2.right * speed);
       transform.Translate(Vector2.up  *Time.deltaTime*speed);
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("TileMap"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SpawnManager.count1 += 25;
            Debug.Log("DD");
         
            Destroy(this.gameObject);
        }
    }
}
