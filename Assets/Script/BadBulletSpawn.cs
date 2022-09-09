using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBulletSpawn : MonoBehaviour
{

    public GameObject[] bulletSpawn;
    public GameObject badBullet;
    private float timer = 1;
    private int index;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if(timer <= 0)
        {
            index = Random.Range(0, 2);
            Instantiate(badBullet, bulletSpawn[index].transform.position, Quaternion.identity);
            timer = 3;
        }
    }
}
