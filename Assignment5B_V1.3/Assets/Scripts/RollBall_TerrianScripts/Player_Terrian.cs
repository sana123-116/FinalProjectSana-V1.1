using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Player_Terrian : MonoBehaviour
{
    public float speed;
    Text name;
    private Rigidbody rb;
    private int count;
    public Text message;
    public Text counter;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
       //counter.text = "Objects Picked: " + count.ToString();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            string label = other.gameObject.name;
            string last_chr = Regex.Match(label, @"\d+").Value;
            name = GameObject.Find("Sphere" + last_chr + "/Canvas/Text").GetComponent<Text>();
            var nameOfCube = name.text.Distinct();
            string letters = "(xs6)";
            var countForLetters = 0;
            var left_parenth = 0;
            var right_parenth = 0;

            foreach (var val in nameOfCube)
            {
                if (val.ToString() == "(")
                {
                    left_parenth++;
                }
                if (val.ToString() == ")")
                {
                    right_parenth++;
                }
                if (!letters.Contains(val))
                {
                    countForLetters++;
                }
            }
            if (countForLetters == 0)
            {
                other.gameObject.SetActive(false);
                name.text = "";
                count++;
                counter.text = "Objects Picked: " + count.ToString();
            }
            if (left_parenth == right_parenth)
            {
                message.text = "Equal Parenthesis";
            }
            else
            {
                message.text = "";
            }
            if (count == 22)
            {
                message.text = "Wow...All Objects Picked";
            }


            // bool a = characters.Any(c => nameOfCube.Contains(c));
            //if (check_palindrome(name.text))
            //{
            //    other.gameObject.SetActive(false);
            //    name.text = "";
            //    message.text = "Wow...It's Palindrome";
            //}
            //else
            //{
            //    message.text = "Not a Palindrome";
            //}
        }
    }
    //public bool check_palindrome(string name_str)
    //{
    //    bool result = false;
    //    string rev;
    //    //string1 = "Malayalam";
    //    char[] ch = name_str.ToCharArray();
    //    Array.Reverse(ch);
    //    rev = new string(ch);
    //    result = name_str.Equals(rev, StringComparison.OrdinalIgnoreCase);
    //    return result;
    //}
}
