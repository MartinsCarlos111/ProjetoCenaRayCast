using UnityEngine;
using System.Collections;

//Classe move.
public class move : MonoBehaviour {

    //Public variables (Mudar caso necessário)
    public float plusChange = 0;
    public float Sensivity;
    public float speed;
    public float jumpPower;

    //Private variables (Não mudar)
    float plus; 
    float jump = 4;

    //Camera Variables (Não Mudar)
    float CurrentX;
    float CurrentY;
    float xd;
    float yd;
    float X;
    float Y;

    void FixedUpdate()
    {
        /*//Camera For FPS
        X += Sensivity * Input.GetAxis("Mouse X");
        Y -= Sensivity * Input.GetAxis("Mouse Y");
        Y = Mathf.Clamp(Y, -90, 80);

        CurrentX = Mathf.SmoothDamp(CurrentX, X, ref xd, Smooth);
        CurrentY = Mathf.SmoothDamp(CurrentY, Y, ref yd, Smooth);
            
        Camera.main.transform.rotation = Quaternion.Euler(CurrentY, CurrentX, 0);

        if (Input.GetMouseButtonDown(0) && Cursor.visible == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //Set Camera Rotation to Player
        Quaternion a = Camera.main.transform.rotation;
        a.x = 0;
        a.z = 0;
        transform.rotation = a;*/

        //Jump
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.Space) && Physics.Raycast(transform.position, -transform.up, out hit, 1.1f))
        {
            GetComponent<Rigidbody>().AddForce(transform.up * jumpPower * 50);
        }

        //Run
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Vertical") > 0)
            plus = plusChange;
        else
            plus = 1;

        //Movement
        var bb = Input.GetAxis("Vertical") * speed * plus * transform.forward;
        var aa = Input.GetAxis("Horizontal") * speed * transform.right;

        //Gravidade
        Vector3 gravity = new Vector3(0, -5, 0);

        //Aplica os componentes
        GetComponent<Rigidbody>().velocity = bb + aa + gravity + new Vector3(0, jump, 0);
    }
}