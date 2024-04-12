using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car")) // Ensure your car has a tag "Car" in the inspector
        {
            // Increment coin count or score here
            Debug.Log("Coin collected!");

            // Optionally, disable or destroy the coin object
            gameObject.SetActive(false);
            // or Destroy(gameObject);
        }
    }
}
