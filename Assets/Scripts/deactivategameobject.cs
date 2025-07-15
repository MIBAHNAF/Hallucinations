using UnityEngine;

public class DeactivateGameObjectOnTrigger : MonoBehaviour
{
    public GameObject objectToDeactivate;  // Assign the GameObject you want to deactivate
    public bool deactivateOnlyOnce = true; // Should it deactivate only once?

    private bool hasDeactivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (!hasDeactivated || !deactivateOnlyOnce))
        {
            if (objectToDeactivate != null)
            {
                objectToDeactivate.SetActive(false);
                hasDeactivated = true;
            }
        }
    }
}
