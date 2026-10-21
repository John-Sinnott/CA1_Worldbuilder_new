using UnityEngine;
using System.Collections;

public class Teleport2 : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    private bool isTeleporting = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isTeleporting || teleportTarget == null || thePlayer == null)
            return;

        // Only respond to the assigned player.
        if (other.transform.root.gameObject != thePlayer &&
            other.gameObject != thePlayer)
            return;

        StartCoroutine(TeleportPlayer());
    }

    private IEnumerator TeleportPlayer()
    {
        isTeleporting = true;

        // Use the assigned PlayerRobot object.
        Transform playerRoot = thePlayer.transform;

        CharacterController controller =
            playerRoot.GetComponent<CharacterController>();

        if (controller != null)
            controller.enabled = false;

        // Move the player to the destination.
        playerRoot.SetPositionAndRotation(
            teleportTarget.position,
            teleportTarget.rotation
        );

        Debug.Log("Moved player to: " + playerRoot.position);

        // Wait one frame before restoring the controller.
        yield return null;

        if (controller != null)
            controller.enabled = true;

        Debug.Log("Player position after teleport: " + playerRoot.position);

        yield return new WaitForSeconds(1f);

        isTeleporting = false;
    }
}