using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBulletSpawn : MonoBehaviour
{

    public GameObject badBullet;
    private float timer = 1;
    private int index;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if(timer <= 0)
        {
            Instantiate(badBullet, new Vector3(Random.Range(-9, 9), 5.35f, 0), Quaternion.identity);
            timer = 3;
        }

    }
}
