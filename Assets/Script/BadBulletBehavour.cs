using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBulletBehavour : MonoBehaviour
{
    private int avalibleHouses;
    private ControllerScript cS;
    private Rigidbody2D rb;
    private float speed = 2;
    public Transform bulletTransform;
    private Vector3 target;
    bool isNull = false; 

    // Start is called before the first frame update
    void Start()
    {
        cS = FindObjectOfType<ControllerScript>();
        rb = GetComponent<Rigidbody2D>();
        avalibleHouses = Random.Range(0, cS.houses.Length);
        while (cS.houses[avalibleHouses] == null)
        {
            avalibleHouses = Random.Range(0, cS.houses.Length);
        }
        if (cS.houses[0] != null)
        {
            if (avalibleHouses == 0)
            {
                target = new Vector3(-7.89f, -3.5f, 0);
            }
        }
        if (cS.houses[1] != null)
        {
            if (avalibleHouses == 1)
            {
                target = new Vector3(-4.54f, -3.5f, 0);
            }
        }
        if (cS.houses[2] != null)
        {
            if (avalibleHouses == 2)
            {
                target = new Vector3(-2.05f, -3.5f, 0);
            }
        }
        if (cS.houses[3] != null)
        {
            if (avalibleHouses == 3)
            {
                target = new Vector3(1.9847f, -3.5f, 0);
            }
        }
        if (cS.houses[4] != null)
        {
            if (avalibleHouses == 4)
            {
                target = new Vector3(4.6853f, -3.5f, 0);
            }
        }
        if (cS.houses[5] != null)
        {
            if (avalibleHouses == 5)
            {
                target = new Vector3(6.8986f, -3.5f, 0);
            }
        }
        Vector3 bulletDirection = target - bulletTransform.position;
        float enemyAngle = Mathf.Atan2(bulletDirection.y, bulletDirection.x) * Mathf.Rad2Deg - 90;
        rb.rotation = enemyAngle;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position == target)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
