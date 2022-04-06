using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D EnemyRB;
    bool obstacleActive = true;

    // Start is called before the first frame update
    void Start()
    {
        EnemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            obstacleActive = false;
            transform.localScale = new Vector3(Mathf.Sign(EnemyRB.velocity.x), 1, 1);
        }
    }

    private void OnTriggerExit2D(Collider other)
    {
        
    }
}
