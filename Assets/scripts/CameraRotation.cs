using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float RotationSpeed;

    public Transform CameraAxisTransform;

    public float MinAngle;
    public float MaxAngle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);

        var newAngelX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
        
        if (newAngelX > 180)
            newAngelX -= 360;

        newAngelX = Mathf.Clamp(newAngelX, MinAngle, MaxAngle);

        CameraAxisTransform.localEulerAngles = new Vector3(newAngelX, 0, 0);
    }
}
