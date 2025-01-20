using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource enter;
    public GameObject control_screen;
    public GameObject Main_menu;
    public void PlayGame()
    {
        enter.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
    }
public void Controls()
    {
        Main_menu.SetActive(false);
        control_screen.SetActive(true); 
    }
public void back()
    {
        Main_menu.SetActive(true);
        control_screen.SetActive(false);
    }
public void Quit()
    {
        Application.Quit();
    }
}
