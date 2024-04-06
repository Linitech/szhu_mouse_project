using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{ 
    
 // float startPosX; // start position on the x-axis
 // float startPosY; // start position on the y-axis
    bool isBeingHeld; // determines if objects are being held




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            gameObject.transform.localPosition = new Vector2(mousePos.x, mousePos.y);
        }
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            isBeingHeld = true;
            Debug.Log("click");
        }

    }


    void OnMouseUp()
    {
        isBeingHeld = false;
        transform.position = Vector2.zero;
    }





}
