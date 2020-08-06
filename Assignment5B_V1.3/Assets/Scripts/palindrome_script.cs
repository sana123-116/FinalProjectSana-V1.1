using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class palindrome_script : MonoBehaviour
{
  public void language_chosen()
    {
        SceneManager.LoadScene(9);
    }
    public void palindrome_world()
    {
        SceneManager.LoadScene(12);
    }
    public void return_back()
    {
        SceneManager.LoadScene(2);
    }
}

