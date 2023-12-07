using UnityEngine;

public class TriggerOn : MonoBehaviour
{
    public GameObject particleEffect; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Candle"))
        {
            ActivateParticleEffect();
        }
    }

    
    private void ActivateParticleEffect()
    {
       
        if (particleEffect != null && !particleEffect.activeSelf)
        {
            particleEffect.SetActive(true);

            
        }
    }
}