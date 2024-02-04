using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Control : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform playerPos;

    public float speed;

    private int health = 3;


    
    
    
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
                   transform.position,
                   playerPos.position,
                   speed * Time.deltaTime);

        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Bullet")
        {
            health--;
        }
    }
}
