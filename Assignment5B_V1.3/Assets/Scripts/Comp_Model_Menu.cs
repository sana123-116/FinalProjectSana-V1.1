using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Comp_Model_Menu : MonoBehaviour
{

    public void palindrome()
    {
        SceneManager.LoadScene(7);
    }
    public void matching_parenthesis()
    {
        SceneManager.LoadScene(8);
    }
    public void return_back()
    {
        SceneManager.LoadScene(0);

    }

}
