using UnityEngine;

public class Guard : MonoBehaviour
{
    public GameObject mishura;
    public GameObject novogodniShapka;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void MishuraKeep()
    {
        anim.SetBool("Keeping", true);
        mishura.SetActive(true);
        anim.SetBool("Keeping", false);
    }

    void ShapkaKeep()
    {
        anim.SetBool("Keeping", true);
        novogodniShapka.SetActive(true);
        anim.SetBool("Keeping", false);
    }
}
