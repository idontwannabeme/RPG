using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RorationAxes
    {
        XandY,
        X,
        Y
    }

    public RorationAxes _axes = RorationAxes.XandY;
    public float _rotationSpeedHor = 5.0f;
    public float _rotationSpeedVer = 5.0f;
    public float maxVert = 45.0f;
    public float minVert = -45.0f;

    private float _RorationX = 0;
    private float _RotationY = 0;
    
        private void Update()
    {
        if(_axes == RorationAxes.XandY)
        {
            _RorationX -= Input.GetAxis("Mouse Y") * _rotationSpeedVer;
            _RorationX = Mathf.Clamp(_RorationX, minVert, maxVert);
            float delta = Input.GetAxis("Mouse X") * _rotationSpeedHor;
            float _RotationY = transform.localEulerAngles.y + delta;

            

            transform.localEulerAngles = new Vector3(_RorationX, _RotationY, 0);
        }
        else if(_axes == RorationAxes.X)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * _rotationSpeedHor, 0);
        }
         else if (_axes == RorationAxes.Y)
        {
            _RorationX -= Input.GetAxis("Mouse Y") * _rotationSpeedVer;
            _RorationX = Mathf.Clamp(_RorationX,minVert,maxVert);
            transform.localEulerAngles = new Vector3(_RorationX, _RotationY, 0);
        }
    }
}
