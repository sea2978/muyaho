using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputOutput : MonoBehaviour
{
    public Rigidbody rig;

    int i = 0;

    public void onClickButton()
    {
        Debug.Log($"버튼이{++i}회눌림");
    }

    void Start()
    {
        Debug.Log("일반");
        Debug.LogWarning("경고");
        Debug.LogError("에러");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            Debug.Log("Space");
            rig.AddForce(Vector3.up * 200);
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("A");
        }

        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("D");
        }

        if (Input.GetKeyUp(KeyCode.A) == true)
        {
            Debug.Log("A up");
        }

        if (Input.GetKeyUp(KeyCode.D) == true)
        {
            Debug.Log("D up");
        }
    }

    public void OnChangeSliderValue(Slider sender)
    {
        Debug.Log($"ChangeValue - { sender.value}");
    }

    public void OnChangeScrollbarValue(Scrollbar sender)
    {
        Debug.Log($"[Scrollbar] ChangeValue - { sender.value}");
    }

    public void OnChangeDDBoxValue(Dropdown sender)
    {
        Debug.Log($"[DropDown] ChangeValue - { sender.value}");
    }

    public void OnChangeInputFieldValue(InputField sender)
    {
        Debug.Log($"[InputField] ChangeValue - { sender.text}");
    }

    public void OnEndEditInputFieldValue(InputField sender)
    {
        Debug.Log($"[InputField] EndEdit - { sender.text}");
    }
}
