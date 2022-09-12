using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public List<Vector3> houses;

    private void Update()
    {
        if(buildings[0] == null && buildings[1] == null && buildings[2] == null && buildings[3] == null && buildings[4] == null && buildings[5] == null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

}
