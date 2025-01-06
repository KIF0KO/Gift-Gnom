using System.Collections;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator anim; // ���������, ��� �������� ������ � ���� ����� � ����������

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log($"�������� ������� � ��������: {collision.name}");
        if (collision.CompareTag("Guard"))
        {
            Debug.Log("������ ����� ���������!");
            anim.SetBool("isOpen", true);
            StartCoroutine(CloseAfterDelay());
        }
    }

    private IEnumerator CloseAfterDelay()
    {
        yield return new WaitForSeconds(5);
        anim.SetBool("isOpen", false);
        Debug.Log("����� �������");
    }
}