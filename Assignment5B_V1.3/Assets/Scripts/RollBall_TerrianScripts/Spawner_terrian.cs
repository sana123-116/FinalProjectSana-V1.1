using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class Spawner_terrian : MonoBehaviour
{
    private string randomString;
    public int thestringlength;
    private static int palindromeLength;
    // public Collider[] colliders;
    public GameObject Cube;
    public GameObject Sphere;
    public void generate_strings()
    {
        List<int> list = new List<int>();
        int randomNumber;

        Text name;
        for (int i = 0; i < palindromeLength; i++)
        {
            randomNumber = Random.Range(0, 9);
            if (!list.Contains(randomNumber) || list.Count == 0)
            {
                list.Add(randomNumber);
            }
            else
            {
                palindromeLength = palindromeLength + 1;
            }
        }
        for (int i = 0; i < 66; i++)
        {
            randomString = "";
            float XPosition = Random.Range(-13, 51);
            float ZPosition = Random.Range(-20, 45);
            var theNewPos = new Vector3(XPosition, 0.5f, ZPosition);

            GameObject sphere = Instantiate(Sphere);
            GameObject cube = Instantiate(Cube);

            sphere.name = "Sphere" + i;
            cube.name = "Cube" + i;
            sphere.transform.position = new Vector3(XPosition, 1.0f, ZPosition);
            cube.transform.position = theNewPos;
            name = GameObject.Find("Sphere" + i + "/Canvas/Text").GetComponent<Text>();
            string[] characters;
            if (i < 44)
            {
                characters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" };
            }
            else
            {
                characters = new string[] { "(", "x", "s", "6", ")" };
            }

            thestringlength = Random.Range(9, 15);

            for (int j = 0; j < thestringlength; j++)
            {
                randomString = randomString + characters[Random.Range(0, characters.Length)];
            }

            name.text = randomString;

        }
        //    string[] characters = new string[] { "a", "b", "c", "d", "e", "f","g","h","i", "j","k","l","m","n","o", "p","q","r","t","u","v","w","y","z" };

    }
    public static int getSetValue;
    public static int GetSetValue
    {
        get
        {
            return getSetValue;
        }
        set
        {
            getSetValue = value;
        }

    }

    void Start()
    {
        palindromeLength = Random.Range(3, 10);
        Spawner.GetSetValue = palindromeLength;
        generate_strings();
    }
}