using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionOnQ : MonoBehaviour
{
    public string sceneName; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
