using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject[] houses;
    public int destroyedCounter;
    private void Update()
    {
        if(destroyedCounter == 6)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

}
