using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
	public Transform reciever;
	public Transform cameraB;

	private bool playerIsOverlapping = false;

	// Update is called once per frame
	void Update () {
		if (playerIsOverlapping)
		{
			
			Debug.Log(reciever.position);
			player.transform.position = reciever.position;
			player.transform.rotation = cameraB.rotation;
			// player.transform.GetComponent<Rigidbody>().useGravity = false;
			

			// float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

			// Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
			// Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
			// transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);

			// Vector3 portalToPlayer = player.position - transform.position;
			// float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

			// // If this is true: The player has moved across the portal
			// if (dotProduct < 0f)
			// {
			// 	float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
			// 	rotationDiff += 180;
			// 	player.Rotate(Vector3.up, rotationDiff);

			// 	Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
			// 	player.position = reciever.position + positionOffset;
			// 	Debug.Log(player.position);

			// 	playerIsOverlapping = false;
			// }
		}
	}

	void OnTriggerEnter (Collider other)
	{
		playerIsOverlapping = true;
		// if (other.tag == "FirstPersonPlayer")
		// {
		// 	playerIsOverlapping = true;
		// }
	}

	void OnTriggerExit (Collider other)
	{
		playerIsOverlapping = false;
		// if (other.tag == "FirstPersonPlayer")
		// {
		// 	playerIsOverlapping = false;
		// }
	}
}