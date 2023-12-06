using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    public GameObject flamePrefab;
    public bool state = false;

    public void Onfire()
    {
        if(state == false)
        {
            flamePrefab.SetActive(true);
            state = true;
        }
        else
        {
            flamePrefab.SetActive(false);
            state = false;
        }
    }

    public void Spread(GameObject other)
    {
        
    }
}
