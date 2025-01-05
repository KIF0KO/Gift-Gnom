using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingState : State
{
    private Player player;
    public override void Enter()
    {
        player = Player.singlton;
        base.Enter();
        player.transformCube.gameObject.SetActive(true);

        player.transformCube.GetComponent<vid>().target = player.target;
    }
    public override void Update()
    {
        base.Update();
        if (Input.GetMouseButtonDown(1))
        {
            player.tr.position = player.target.transform.position + new Vector3(0,1,0);
            player.tr.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Exit();
        }
    }
    public override void Exit()
    {
        base.Exit();
        player.transformCube.gameObject.SetActive(false);
        player.cam.transform.rotation = player.cameraCube.transform.rotation;
        Player.singlton._SM.Initialize(new MoveState());
        
    }
}
