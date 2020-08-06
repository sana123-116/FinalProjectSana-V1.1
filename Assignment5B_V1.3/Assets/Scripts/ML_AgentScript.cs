using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ML_AgentScript : MonoBehaviour
{
    public void penguin()
    {
        SceneManager.LoadScene(5);
    }
    public void humminbird()
    {
        SceneManager.LoadScene(6);
    }
    public void return_back(){
        SceneManager.LoadScene(0);
    }
}
