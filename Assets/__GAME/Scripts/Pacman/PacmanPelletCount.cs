using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PacmanPelletCount : MonoBehaviour
{
    public GameObject parentObject; // Reference to the parent GameObject containing the objects to count
    private TextMeshProUGUI textMeshPro; // Reference to the TextMeshPro component

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>(); // Get the TextMeshPro component attached to this GameObject
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshPro component not found.");
            enabled = false; // Disable the script if TextMeshPro component is not found
        }
    }

    void Update()
    {
        if (parentObject != null)
        {
            // Count the number of active objects within the parent GameObject
            int count = CountActiveChildObjects(parentObject.transform);

            // Update the TextMeshPro text with the count
            textMeshPro.text = "Pellets: " + (count-244);
            if (count <= 240)
            {
                Debug.LogWarning("Win Condition Met!!!");
            }
        }
        else
        {
            Debug.LogWarning("Parent object not assigned.");
        }
    }

    // Recursive function to count active child objects
    int CountActiveChildObjects(Transform parent)
    {
        int count = 0;
        foreach (Transform child in parent)
        {
            if (child.gameObject.activeSelf)
            {
                count++;
            }
            // If the child has children, recursively count them
            if (child.childCount > 0)
            {
                count += (CountActiveChildObjects(child));
            }
        }
        return count;
    }
}