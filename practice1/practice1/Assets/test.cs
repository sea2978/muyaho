using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public Rigidbody rig;

    void Start()
    {
        Debug.Log("�Ϲ� �α�");
        Debug.LogError("���� �α�");
        Debug.LogWarning("��� �α�");
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            Debug.Log("W�� ����");
        }
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("A�� ����");
        }
        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("S�� ����");
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("D�� ����");
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.LeftControl) == true) 
        {
            Debug.Log("��Ʈ�Ѱ�W�� ����");
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
