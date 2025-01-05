using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPossessItem : MonoBehaviour
{
    public int numItem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log(numItem);
                if (Player.singlton.target.GetComponent<OnPossessItem>().numItem != numItem)
                {
                    Debug.Log("EnterTr");
                    CollisionCalc.instance.CallCollDec(GetComponent<Collider>());
                }
            
        }
    }
}
