using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    private Rigidbody2D rb;
    public GameObject shotLocation;
    public bool canFire;
    float timer = 1;

    // Update is called once per frame
    public void Update()
    {
        Vector2 barrelLocation = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 Cp = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = barrelLocation - Cp;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);

        timer =- 1 * Time.deltaTime;

        if (timer <= 0 && canFire != true)
        {
            canFire = true;
        }

        if (Input.GetMouseButtonDown(0) && canFire == true)
        {
            canFire = false;
            Instantiate(bullet, new Vector2(shotLocation.transform.position.x, shotLocation.transform.position.y), Quaternion.identity);
            timer = 1;
        }

    }
}
