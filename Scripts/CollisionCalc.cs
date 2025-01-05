using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCalc : MonoBehaviour
{
    public static CollisionCalc instance;
    public delegate void Parampam();
    public event Parampam CollisionDetect;

    private void Awake()
    {
        instance = this;
    }
    

    
    public void CallCollDec(Collider h) {
        Player.singlton.target = h.transform.gameObject;
        CollisionDetect();
    }
}
