using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class Enemy2 : MonoBehaviour
{

    private Transform pl;
    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
       
        
        pl = GameObject.FindWithTag("Player").transform;
        agent.updateRotation = false;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 360f);
        agent.SetDestination(pl.position);
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Wave"))
        {
            SpawnManager.count1 += 25;
            
            Destroy(this.gameObject);
        }
    }
}
