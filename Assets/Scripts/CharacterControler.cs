using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    public Transform character;
    private float moveHorizontal;
    private float moveVertical;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementValue();
        ApplyMovement();
    }

    void MovementValue()
    {
        moveHorizontal = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
        moveVertical = Input.GetAxis ("Vertical") * Time.deltaTime * speed;  
    }

    void ApplyMovement()
    {
        Vector2 moveValue = new Vector2(moveHorizontal, moveVertical);
        character.Translate(moveValue);
    }
}
