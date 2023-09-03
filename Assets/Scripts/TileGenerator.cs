using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public string myName;
    public int myAge;


    // Start is called before the first frame update
    void Start()
    {
        IDMe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void IDMe()
    {
        Debug.Log("Hello world!");
        Debug.Log("My name is " + myName + ".");
        Debug.Log("I am " + myAge + " years old.");
    }
}
