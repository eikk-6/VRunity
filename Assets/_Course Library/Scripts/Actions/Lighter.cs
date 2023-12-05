using UnityEngine;

public class Lighter : MonoBehaviour
{
    public GameObject flamePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Candle"))
        {
            LightCandle(other.gameObject);
        }
    }

    private void LightCandle(GameObject candle)
    {
        GameObject flame = Instantiate(flamePrefab, candle.transform.position, Quaternion.identity);
        flame.transform.parent = candle.transform;

        flame.AddComponent<OnVelocity>();

        flame.transform.parent = transform;
    }
}