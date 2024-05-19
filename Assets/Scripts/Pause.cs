using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject Misuc;
    [SerializeField] private GameObject MenuPause;
    private AudioSource[] AudioSouses;
    public bool GamePaused;


    void Start()
    {
        MenuPause.SetActive(false);
        GamePaused = false;

        AudioSouses = Misuc.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused) 
            {
                PauseOff();
                GamePaused = false;
            }
            else
            {
                PauseOn();
                GamePaused = true;
            }
        }
    }

    private void SetActuveAudioSourses(bool value)
    {
        for (int i = 0; i < AudioSouses.Length; i++)
        {
            if (value)
            {
                AudioSouses[i].Play();
            }
            else
            {
                AudioSouses[i].Pause();
            }
        }
    }

    public void PauseOn()
    {
        MenuPause.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        SetActuveAudioSourses(false);
    }

    public void PauseOff()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SetActuveAudioSourses(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }  
}
