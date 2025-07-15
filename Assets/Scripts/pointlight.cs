using UnityEngine;
using System.Collections;

public class FlickerAndKillLights : MonoBehaviour
{
    public float flickerDuration = 2f;
    public float flickerSpeed = 0.1f;
    public AudioSource flickerSound;

    private Light[] pointLights;

    private void Start()
    {

        pointLights = FindObjectsByType<Light>(FindObjectsSortMode.None);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(FlickerAndTurnOff());
            Destroy(gameObject);
        }
    }

    IEnumerator FlickerAndTurnOff()
    {
        float timer = 0f;


        if (flickerSound) flickerSound.Play();

        while (timer < flickerDuration)
        {
            foreach (Light light in pointLights)
            {
                if (light != null && light.type == LightType.Point)
                {
                    light.enabled = !light.enabled;
                }
            }

            timer += flickerSpeed;
            yield return new WaitForSeconds(flickerSpeed);
        }


        foreach (Light light in pointLights)
        {
            if (light != null && light.type == LightType.Point)
            {
                light.enabled = false;
            }
        }
    }
    public void RestoreLights()
    {
        foreach (Light light in pointLights)
        {
            if (light != null && light.type == LightType.Point)
            {
                light.enabled = true;
            }
        }
    }
    public void TurnOffLights()
    {
        foreach (Light light in pointLights)
        {
            if (light != null && light.type == LightType.Point)
            {
                light.enabled = false;
            }
        }
    }


}

