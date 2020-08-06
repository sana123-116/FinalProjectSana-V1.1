using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class matching_parenth : MonoBehaviour
{
 public void language_chosen()
    {
        SceneManager.LoadScene(10);
    }
    public void matching_par()
    {
        SceneManager.LoadScene(11);
    }

    public void return_back()
    {
        SceneManager.LoadScene(2);
    }
}
