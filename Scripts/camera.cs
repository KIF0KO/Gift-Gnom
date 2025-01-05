using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float MousSens = 100f;

    float xRot = 0f;

    public static bool settingsIsOpen = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Look()
    {
        float mousX = Input.GetAxis("Mouse X") * MousSens * Time.deltaTime;
        float mousY = Input.GetAxis("Mouse Y") * MousSens * Time.deltaTime;
        xRot -= mousY;
        //xRot = Mathf.Clamp(xRot, -90f, 90f);

        Player.singlton.thingCam_0.transform.Rotate(Vector3.up * mousX);
        Player.singlton.thingCam_1.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        Player.singlton.tr.Rotate(Vector3.up * mousX);
        Player.singlton.cam.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        Look();
    }
}
