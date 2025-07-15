using UnityEngine;
using UHFPS.Runtime;
public class LetThereBeLight : MonoBehaviour
{
    public FlickerAndKillLights lightsController; 
    public GameObject postPowerTrigger; 
    public GameObject medicineDrawer;

    public void OnBreakerPulled()
    {
        lightsController.RestoreLights();

        
        if (postPowerTrigger != null)
        {
            postPowerTrigger.SetActive(true);
        }
        if (medicineDrawer != null)
            medicineDrawer.SetActive(true);

     
    }

    public void OnBreakerShutDown()
    {
        lightsController.TurnOffLights();
    }
}

