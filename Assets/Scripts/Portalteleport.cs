using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    public Transform targetPortal; // The portal the player will teleport to
    public float teleportCooldown = 1f; // Time before the player can teleport again

    private bool canTeleport = true; // Prevent multiple teleports in a short time

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canTeleport)
        {
            StartCoroutine(TeleportPlayer(other));
        }
    }

    private IEnumerator TeleportPlayer(Collider player)
    {
        canTeleport = false;

        // Teleport the player to the target portal's position
        player.transform.position = targetPortal.position;

        // Optional: Align the player's rotation with the target portal's rotation
        player.transform.rotation = targetPortal.rotation;

        // Wait for the cooldown before allowing another teleport
        yield return new WaitForSeconds(teleportCooldown);
        canTeleport = true;
    }
}
