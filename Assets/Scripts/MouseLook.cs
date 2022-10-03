using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public LoadPlayer loadPlayerScript;
    public float mouseSensitivity = 150f;     //mouse speed
    

    public float playerSpeed = 10f;
    //camera rotation across x axis
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;         //mouse x axis value with speed and irrespective of frame rate speed
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;      //mouse y axis value with speed and irrespective of frame rate speed
        
        Transform playerBody;
        playerBody = loadPlayerScript.newPlayerObject.transform;
        
        playerBody.transform.Rotate(Vector3.up * mouseX);          //player rotation across y axis thus using x axis value of mouse

        
        xRotation -= mouseY;        //changing the value of variable using y axis value of mouse
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);       //forcing the camera rotation to not go beyond (-90,90), that is why we used variable and not used the x axis value of mouse dirctly  
        transform.localRotation = Quaternion.Euler(xRotation ,0f,0f);         //camera rotation across x axis using variable value that is changed from y axis of mouse and clamped also


        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        
        
        playerBody.transform.Translate(Vector3.forward * (Time.deltaTime * verticalInput * playerSpeed));
        playerBody.transform.Translate(Vector3.right * (Time.deltaTime * horizontalInput * playerSpeed));


        GameObject playerInstantiated = loadPlayerScript.newPlayerObject;
        gameObject.transform.SetParent(playerInstantiated.transform);
    }
}
