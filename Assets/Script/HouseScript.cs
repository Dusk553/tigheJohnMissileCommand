using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseScript : MonoBehaviour
{
    ControllerScript cs;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cs = FindObjectOfType<ControllerScript>();
        if (collision.gameObject.tag == "Enemy")
        {
            cs.destroyedCounter += 1;
            Destroy(gameObject);
        }
    }
}
