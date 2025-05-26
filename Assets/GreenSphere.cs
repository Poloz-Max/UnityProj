using UnityEngine;

public class GreenSphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.RegisterSphereTouched();
            Destroy(gameObject); 
        }
    }
}
