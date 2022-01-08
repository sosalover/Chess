using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 pieceState;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 findClosestSquare(Vector3 pos)
    {
        Debug.Log("Hello");
        Debug.Log(pos);
        Vector3 newPos;
        float x = Mathf.Floor(pos.x+.5f);
        Debug.Log(x);
        float y = Mathf.Floor(pos.y+.5f);
        newPos = new Vector3(x,y, pos.z);
        return newPos;
    }
}
