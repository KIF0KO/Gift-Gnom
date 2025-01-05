using UnityEngine;

public class Gift_Throw : MonoBehaviour
{
    public GameObject gift;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
            Gift_Throwing();
    }

    void Gift_Throwing()
    {
        Instantiate(gift);
    }
}
