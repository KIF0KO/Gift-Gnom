using UnityEngine;

public class Gift_Throw : MonoBehaviour
{
    public GameObject gift;
    public GameObject spawn_point;
    private Rigidbody rb;
    private Vector3 vector;

    private void Start()
    {
        rb = gift.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
            Gift_Throwing();
        vector = transform.position;
    }

    void Gift_Throwing()
    {
        Instantiate(gift, spawn_point);
        new Vector3();
        rb.AddForce(Vector3.forward * 5);
    }
}