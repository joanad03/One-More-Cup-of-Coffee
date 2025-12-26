using UnityEngine;

public class WelcomeTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
