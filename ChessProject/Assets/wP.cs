using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wP : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mousePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = -1;
        transform.position = mousePos;
        Debug.Log(mousePos);
        
    }
    private void OnMouseUp()
    {
        transform.position = FindObjectOfType<Board>().findClosestSquare(mousePos);
    }
}
