using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public string myName;
    public int myAge;
    public int rowCount = 6;
    public GameObject gridSquare;
    public Transform placer;

    // Start is called before the first frame update
    void Start()
    {
        //IDMe();
        GridBuilder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PositionPlacerX()
    {
        placer.position += Vector3.right;
    }

    void PlaceSquare()
    {
        GameObject newSquare;
        newSquare = Instantiate(gridSquare, placer.position, placer.rotation);
        newSquare.transform.parent = transform;
    }

    void GridBuilder()
    {
        for (int i = 0; i < rowCount; i++)
        {
            PlaceSquare();
            PositionPlacerX();
        }
    }


    void IDMe()
    {
        Debug.Log("Hello world!");
        Debug.Log("My name is " + myName + ".");
        Debug.Log("I am " + myAge + " years old.");
    }
}
