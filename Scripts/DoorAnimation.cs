using System.Collections;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator anim; // Убедитесь, что аниматор связан с этим полем в инспекторе

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log($"Сработал триггер с объектом: {collision.name}");
        if (collision.CompareTag("Guard"))
        {
            Debug.Log("Объект врага обнаружен!");
            anim.SetBool("isOpen", true);
            StartCoroutine(CloseAfterDelay());
        }
    }

    private IEnumerator CloseAfterDelay()
    {
        yield return new WaitForSeconds(5);
        anim.SetBool("isOpen", false);
        Debug.Log("Дверь закрыта");
    }
}