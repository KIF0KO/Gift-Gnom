using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player singlton { get; private set;}

    public StateMachine _SM;

    public Rigidbody rb;
    public Transform tr;
    public Camera cam;

    public Transform transformCube;
    public Camera cameraCube;

    public GameObject target;

    public GameObject thingCam_0;
    public GameObject thingCam_1;

    private void Awake()
    {
        singlton = this;
    }
    void Start()
    {
        _SM = new StateMachine();
        _SM.Initialize(new MoveState());
        
    }

    void Update()
    {
        _SM.CurrentState.Update();
        Debug.Log(target.GetComponent<OnPossessItem>().numItem);
    }
}
