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

    // Start is called before the first frame update
    void Start()
    {
        cS = FindObjectOfType<ControllerScript>();
        rb = GetComponent<Rigidbody2D>();
        avalibleHouses = Random.Range(0, cS.houses.Count);
        Vector3 bulletDirection = cS.houses[avalibleHouses] - bulletTransform.position;

        target = new Vector3(cS.houses[avalibleHouses].x, cS.houses[avalibleHouses].y, 0);

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
