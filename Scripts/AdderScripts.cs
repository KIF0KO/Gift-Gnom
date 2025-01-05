using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdderScripts : MonoBehaviour
{
    private GameObject[] list;
    private void Awake()
    {
        list = GameObject.FindGameObjectsWithTag("Possess");

        for(int i =0; i < list.Length; i++)
        {
            Debug.Log("PereBor");
            list[i].AddComponent<OnPossessItem>();
            list[i].GetComponent<OnPossessItem>().numItem = i;
        }
    }
}
