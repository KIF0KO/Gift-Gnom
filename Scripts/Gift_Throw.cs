using UnityEngine;

public class Gift_Throw : MonoBehaviour
{
    public GameObject gift;
    public float throwForce = 500f;
    public float giftLifetime = 5f;

    public int maxGifts = 5;
    private int activeGiftCount = 0;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Gift_Throwing();
        }
    }

    void Gift_Throwing()
    {
        if (activeGiftCount >= maxGifts)
        {
            return;
        }

        GameObject spawnedGift = Instantiate(
            gift,
            transform.position + transform.forward * 1.5f,
            Quaternion.identity
        );

        activeGiftCount++;

        Rigidbody rb = spawnedGift.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(transform.forward * throwForce);
        }

        StartCoroutine(DestroyAfterTime(spawnedGift, giftLifetime));
    }

    System.Collections.IEnumerator DestroyAfterTime(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);

        Destroy(obj);
        activeGiftCount--;
    }
}