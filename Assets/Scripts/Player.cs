using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int count1 = 0;
    public Text score;
    [SerializeField] private Rigidbody2D rb;
    private float hori;
    private float vert;
   
  
    public float rotationSpeed = 5f;
    [SerializeField] private GameObject wave;
    private float count = 0;
    private Vector3 reset = new Vector3(-0.23f, 0.18f, 0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Cursor.visible = false;
      //  Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        mousePosition.z = 0f;      


        Vector3 direction = mousePosition - transform.position;  
        
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        hori = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        
        hori = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

       // Vector2 movement = new Vector2(hori, vert);
       // rb.velocity = movement * speed;
      if(Input.GetMouseButtonDown(0))
        {
            Instantiate(wave, transform.position, transform.rotation);
            
        }
      if(count == 1)
        {
            transform.position = reset;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TileMap"))
        {
            rb.velocity = Vector2.zero;
            count++;
        }
        if (collision.gameObject.CompareTag("Enemy") && collision.gameObject.CompareTag("Wave"))
        {
            Debug.Log("UU");
            count1 += 25;
            score.text = "Score: " + count1;

        }
    }
    
}





















