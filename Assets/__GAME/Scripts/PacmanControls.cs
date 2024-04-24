using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PacmanControls : MonoBehaviour
{
    public Pacman pacman; // Reference to the Pacman script

    private void Update()
    {
        // Toggle prepareRight when the right arrow key is pressed
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            pacman.prepareRight = !pacman.prepareRight;
        }

        // Toggle prepareLeft when the left arrow key is pressed
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            pacman.prepareLeft = !pacman.prepareLeft;
        }

        // Toggle goBack when the down arrow key is pressed
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            pacman.goBack = !pacman.goBack;
        }

        // Toggle moving when the up arrow key is pressed
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            pacman.moving = !pacman.moving;
        }

        // Start the game when the space key is pressed
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Pacman.GameStarted = true;
        }
    }
}
