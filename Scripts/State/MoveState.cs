using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    private float _speedDash = 10f;
    Player pl;
    Rigidbody rb;

    public float MousSens = 100f;
    float xRot = 0f;

    private Transform tr;
    private Camera cam;

    private Vector3 pointOnScreen;

    private float _periodTimer;
    private bool _isTimerActive = false;
    public override void Enter()
    {
        
        pointOnScreen = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        
        pl = Player.singlton;
        tr = pl.tr;
        cam = pl.cam;
        rb = pl.rb;
        base.Enter();
        Cursor.lockState = CursorLockMode.Locked;
        cam.enabled = true;
        tr.gameObject.SetActive(true);

        CollisionCalc.instance.CollisionDetect += IsPlayerCollision;
        Dash();
    }

    public override void Exit()
    {
        
        cam.enabled = false;
        tr.gameObject.SetActive(false);
        base.Exit(); 
        Player.singlton._SM.Initialize(new ThingState());
    }
    public override void Update()
    {
        base.Update();

        
        Dash();
        Look();
        if (_isTimerActive)
        {
            if (_periodTimer <= Time.time)
            {
                _isTimerActive = false;
                rb.linearVelocity = Vector3.zero;
            }
            else
            {
                Debug.Log(_periodTimer - Time.time);
            }
        }
    }
    private void Look()
    {
        float mousX = Input.GetAxis("Mouse X") * MousSens * Time.deltaTime;
        float mousY = Input.GetAxis("Mouse Y") * MousSens * Time.deltaTime;
        xRot -= mousY;

        Player.singlton.thingCam_0.transform.Rotate(Vector3.up * mousX);
        Player.singlton.thingCam_1.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        tr.Rotate(Vector3.up * mousX);
        cam.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }
    private void Dash()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rb.linearVelocity = Vector3.zero;
            Ray ray = cam.ScreenPointToRay(pointOnScreen);

            rb.linearVelocity = ray.direction * _speedDash;
            _periodTimer = Time.time + 0.5f;
            _isTimerActive = true;
        }
    }
    
    private void IsPlayerCollision()
    {
        Exit();
    }
}

