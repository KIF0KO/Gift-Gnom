using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            SceneManager.LoadScene("KIFOKO Scene");
    }
}
