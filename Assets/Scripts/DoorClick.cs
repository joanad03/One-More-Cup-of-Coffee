using UnityEngine;

public class DoorClick : MonoBehaviour
{
    public Animator animator;

    void OnMouseDown() // Detecta clique/tap no Collider
    {
        animator.Play("DoorOpen");
    }
}
