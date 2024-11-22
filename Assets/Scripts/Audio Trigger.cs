using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour

{
    // Reference to the AudioSource component
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && audioSource != null)
        {
            Debug.Log("Player entered trigger - Enabling AudioSource and Playing Audio.");

            if (!audioSource.enabled)
            {
                audioSource.enabled = true; // Enable the AudioSource
            }

            if (!audioSource.isPlaying)
            {
                audioSource.Play(); // Play the audio
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && audioSource != null)
        {
            Debug.Log("Player exited trigger - Stopping Audio and Disabling AudioSource.");

            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // Stop the audio
            }

            audioSource.enabled = false; // Disable the AudioSource
        }
    }
}