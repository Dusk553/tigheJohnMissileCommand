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

    // Start is called before the first frame update
    void Start()
    {
        avalibleHouses = Random.Range(0, cS.houses.Count);
        Vector2 bulletDirection = cS.houses[avalibleHouses].transform.position - bulletTransform.position;
        float enemyAngle = Mathf.Atan2(bulletDirection.y, bulletDirection.x) * Mathf.Rad2Deg - 90;
        rb.rotation = enemyAngle;
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, cS.houses[avalibleHouses].transform.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            Destroy(gameObject);
        }
    }
}
