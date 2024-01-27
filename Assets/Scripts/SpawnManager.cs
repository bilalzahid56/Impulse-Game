using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnManager : MonoBehaviour
{
   
    public  Text score;
    public static int  count1 = 0;
    // private GameObject player;
    // Start is called before the first frame update
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;
    private Vector3 distance1 = new Vector3(-12.48f, 9.66f, 0);
    private Vector3 distance2 = new Vector3(12.48f, 9.66f, 0);
    private Vector3 distance3 = new Vector3(-12.48f, -8.96f, 0);
    private Vector3 distance4 = new Vector3(12.48f, -8.96f, 0);
    void Start()
    {
        //score = GetComponent<Text>();
        InvokeRepeating("SpawnleftUpper", 5f, 6f);
        InvokeRepeating("SpawnRightUpper", 7f, 9f);
        InvokeRepeating("SpawnLeftLower", 6f, 9f);
        InvokeRepeating("SpawnRightLower", 6f, 6f);

       // UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + count1;
        // UpdateScoreText();
    }
    void UpdateScoreText()
    {
       
      
 ;
    }
    void SpawnleftUpper()
    {
        Instantiate(enemy1, distance1, Quaternion.identity);
    }
    void SpawnRightUpper()
    {
        Instantiate(enemy1, distance2, Quaternion.identity);
    }
    void SpawnLeftLower()
    {
        Instantiate(enemy2, distance3, Quaternion.identity);
    }
    void SpawnRightLower()
    {
        Instantiate(enemy2, distance4, Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && collision.gameObject.CompareTag("Wave"))
        {
            Debug.Log("UU");
           


        }
    }
    

}










