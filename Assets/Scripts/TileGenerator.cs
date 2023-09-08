using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    public string myName;
    public int myAge;
    public int rowCount = 6;
    public int columnCount = 6;
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

    void PositionPlacerX(Vector3 posUpdate)
    {
        placer.position += posUpdate;
    }

    void PositionPlacerY()
    {
        placer.position += Vector3.down;
    }

    void PlaceSquareX()
    {
        GameObject newSquare;
        newSquare = Instantiate(gridSquare, placer.position, placer.rotation);
        newSquare.transform.parent = transform;
    }

    void PlaceSquareY()
    {
        GameObject newSquare;
        newSquare = Instantiate(gridSquare, placer.position, placer.rotation);
        newSquare.transform.parent = transform;
    }

    void GridBuilder()
    {
        for (int i = 0; i < rowCount; i++)
        {
            PlaceSquareX();
            PositionPlacerX(Vector3.right);
        }

        PositionPlacerX(Vector3.left * rowCount);


        for (int i = 0; i < columnCount; i++)
        {
            for (int q = 0; q < rowCount; q++)
            {
                PlaceSquareX();
                PositionPlacerX(Vector3.right);
            }

            PositionPlacerX(Vector3.left * rowCount);
            //PlaceSquareY();
            PositionPlacerY();
        }
    }


    void IDMe()
    {
        Debug.Log("Hello world!");
        Debug.Log("My name is " + myName + ".");
        Debug.Log("I am " + myAge + " years old.");
    }
}
