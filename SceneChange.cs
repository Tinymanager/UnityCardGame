using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(2);
        }

    }
}
