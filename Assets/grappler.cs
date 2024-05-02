using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappler : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _distancejoint; 

    // Start is called before the first frame update
    void Start()
    {
        _distancejoint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            _lineRenderer.SetPosition(0, mousePos);
            _lineRenderer.SetPosition(1, transform.position);
            _distancejoint.connectedAnchor = mousePos;
            _distancejoint.enabled = true;
            _lineRenderer.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _distancejoint.enabled = false;
            _lineRenderer.enabled = false;
        }
        if (_distancejoint.enabled)
        {
            _lineRenderer.SetPosition(1, transform.position);
        }
    }
}
