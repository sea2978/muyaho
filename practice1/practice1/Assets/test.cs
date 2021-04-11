using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Rigidbody rig;

    void Start()
    {
        Debug.Log("일반 로그");
        Debug.LogError("에러 로그");
        Debug.LogWarning("경고 로그");
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            Debug.Log("W가 눌림");
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("A가 눌림");
        }
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("S가 눌림");
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("D가 눌림");
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.LeftControl) == true) 
        {
            Debug.Log("컨트롤과W가 눌림");
        }

        if (Input.GetKey(KeyCode.W))
        {
            rig.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForce(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForce(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector3.up * 300);
        }
    }
}
