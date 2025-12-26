using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLISAO DETETADA");
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
