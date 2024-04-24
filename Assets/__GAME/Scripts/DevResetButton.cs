using System.Collections;
using UnityEngine;

public class DevResetButton : MonoBehaviour
{
    // Reference to the GameObject containing the Pacman script
    public GameObject pacmanGameObject;
    // Reference to the GameObject triggering the reset
    public GameObject devController;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the DevController GameObject
        if (other.gameObject == devController)
        {
            Debug.Log("Dev Controller is interacting with Dev Reset Button.");

            // Retrieve the Pacman script component from the GameObject
            Pacman pacman = pacmanGameObject.GetComponent<Pacman>();

            // Check if the Pacman script component is not null
            if (pacman != null)
            {
                // Call the ResetPacmanPosition function in the Pacman script
                pacman.ResetPacmanPosition();
            }
            else
            {
                Debug.LogWarning("Pacman script component not found on the specified GameObject.");
            }
        }
    }
}
