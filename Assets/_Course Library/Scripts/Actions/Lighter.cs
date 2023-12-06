using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public GameObject flamePrefab;
    public bool state = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Candle"))
        {
            LightCandle(other.gameObject);
        }
    }

    public void LightCandle(GameObject candle)
    {
        if (state == false)
        {
            candle.SetActive(true);
        }
        else
            candle.SetActive(false);
    }
}