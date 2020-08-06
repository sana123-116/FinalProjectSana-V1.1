using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu_script : MonoBehaviour
{
    public void play_penguin()
    {
        SceneManager.LoadScene(1);

    }
    public void play_humminbird()
    {
        SceneManager.LoadScene(2);
    }
}
