using UnityEngine;

public class AspiradorRotacao : MonoBehaviour
{
    public float velocidade = 100f; // graus por segundo

    void Update()
    {
        // Gira o aspirador no eixo Y
        transform.Rotate(Vector3.up * velocidade * Time.deltaTime);
    }
}
