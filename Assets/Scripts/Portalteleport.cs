using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTeleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportPosition;

    private bool canTeleport = false;

    void Start()
    {
        // Allow teleportation only after a short delay
        StartCoroutine(EnableTeleport());
    }

    private IEnumerator EnableTeleport()
    {
        // Wait for a short period before allowing teleportation
        yield return new WaitForSeconds(1f);
        canTeleport = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (canTeleport && other.CompareTag("Player"))
        {
            Player.transform.SetPositionAndRotation(TeleportPosition.transform.position, Quaternion.identity);
        }
    }
}
