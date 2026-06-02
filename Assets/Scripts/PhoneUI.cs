using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class PhoneUI : MonoBehaviour
{
    [Header("Prepared Objects")]
    public List<GameObject> ARObjects;
    public TextMeshProUGUI UIObjectName;

    [Header("Interactable Values")]
    public GameObject SelectedObject;
    private int CurrentARObjectIndex;
    //private bool ObjectCurrentlyVisible = false;

    public void Start()
    {
        CurrentARObjectIndex = 0;
        SelectedObject = ARObjects[0];
        UIObjectName.text = SelectedObject.name;
    }
    public void ShowObject()
    {
       // ObjectCurrentlyVisible = true;
        SelectedObject.SetActive(true);
    }
    public void HideObject()
    {
       // ObjectCurrentlyVisible = false;
        SelectedObject.SetActive(false);
    }

    public void ChangeSelectedObject()
    {
        //if (ObjectCurrentlyVisible == false)
        //{
            if (CurrentARObjectIndex == 2)
            {
                CurrentARObjectIndex = 0;
            }
            else
            {
                CurrentARObjectIndex += 1;
            }
            SelectedObject = ARObjects[CurrentARObjectIndex];
            UIObjectName.text = SelectedObject.name;
            //Debug.Log(SelectedObject.name);
        //}
    }

    public void ShowAndHideObject()
    {
        if (SelectedObject.activeInHierarchy == true)
        {
            HideObject();
        }
        else
        {
            ShowObject();
        }
        Debug.Log(SelectedObject);
        Debug.Log(SelectedObject.activeInHierarchy);
    }

    //public void Update()
    //{

    //}

}
