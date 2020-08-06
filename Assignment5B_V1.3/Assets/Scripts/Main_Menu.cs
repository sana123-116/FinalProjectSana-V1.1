using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void ML_Agents()
    {
        SceneManager.LoadScene(1);
    }

    public void Computationa_Models()
    {
        SceneManager.LoadScene(2);
    }

    public void List_ofItems_Learned()
    {
        SceneManager.LoadScene(3);
    }
    public void Instructor_Lab()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
