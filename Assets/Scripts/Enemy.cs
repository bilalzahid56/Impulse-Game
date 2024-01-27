using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
  
    private Transform pl;
 
    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent agent;
  //  [SerializeField] private Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
      
        pl= GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        //agent.updatePosition = false;
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, -1800f);
         agent.SetDestination(pl.position);
        //  transformeulerAngles(0, 0, transform.rotation);
        // transform.q(0, 0, transform.rotation.z);
        //  transform.rotation.SetEulerRotation(0, 0,);
     //   transform.position = player.transform.position*Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Wave"))
        {
            

       
            Destroy(this.gameObject);
        }
    }
}
