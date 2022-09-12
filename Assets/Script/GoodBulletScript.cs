using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBulletScript : MonoBehaviour
{
    // Part of this code is referencing Unity 2D Aim and Shoot at mouse Tutorial by MoreBBlakeyyy
    private float speed = 2;
    private Camera mainCam;
    Rigidbody2D rb;
    private Vector3 mousePos;
    private Vector3 target;
    public Animator animator;
    public GameObject radius;

    public void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;

        target = new Vector3(mousePos.x, mousePos.y, 0);

        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;
        float rotate = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotate + 90);
    }
    private void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (gameObject.transform.position == target)
        {
            speed = 0;
            rb.velocity = new Vector2(target.x, target.y).normalized * speed;
            radius.SetActive(true);
            animator.SetBool("Stopped", true);
        }
    }

    public void Explosion()
    {
        Destroy(gameObject);
    }
}
