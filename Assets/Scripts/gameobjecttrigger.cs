using UnityEngine;

public class ActivateGameObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToActivate;  // Assign the GameObject you want to activate
    public bool activateOnlyOnce = true; // Should it activate only once?
    
    private bool hasActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (!hasActivated || !activateOnlyOnce))
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
                hasActivated = true;
            }
        }
    }
}
