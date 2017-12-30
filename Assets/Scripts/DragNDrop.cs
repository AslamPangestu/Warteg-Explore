using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNDrop : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;
    private float firstX;
    private GameObject obj;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (gameObject.CompareTag("Makanan"))
        {
            obj = Instantiate(gameObject, transform.position, transform.rotation);
        }
        firstY = transform.position.y;
        firstX = transform.position.x;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    private void OnMouseUp()
    {
        transform.position = new Vector3(firstX, firstY, transform.position.z);
        Destroy(obj);
    }
}
