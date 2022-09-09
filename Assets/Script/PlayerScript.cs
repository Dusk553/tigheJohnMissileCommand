using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bullet;
    private float speed = 3;
    private Rigidbody2D rb;
    public GameObject shotLocation;

    // Update is called once per frame
   /* public void Update()
    {
        Vector2 checkBarrel = Camera.main.ScreenToWorldPoint(new Vector2(Input.checkBarrel.x, Input.checkBarrel.y));
        Vector2 Cp = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = checkBarrel - Cp;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        Quaternion angleAxis = Quaternion.AxisAngle(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, new Vector2(shotLocation.transform.position.x, shotLocation.transform.position.y), Quaternion.identity);
        }
    }*/
}
