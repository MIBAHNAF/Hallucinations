using UnityEngine;
using UHFPS.Runtime;

public class TriggerFlickeringLights : MonoBehaviour
{
    [Tooltip("Assign all FlickeringLight components you want to activate")]
    public FlickeringLight[] lightsToFlicker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (var flicker in lightsToFlicker)
            {

                flicker.enabled = true;
            }


            gameObject.SetActive(false);
        }
    }
}
