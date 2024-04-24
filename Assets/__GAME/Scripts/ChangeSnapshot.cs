using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ChangeSnapshot : MonoBehaviour
{
public AudioMixerSnapshot newSnapshot;
public AudioMixerSnapshot oldSnapshot;
public float transitionTime = 1.0f;

    // void Start()
    // {
    //     oldSnapshot.TransitionTo(transitionTime);
    // }

private void OnTriggerEnter(Collider other)
{
    if (other.GetComponent<Collider>().name == "ColliderB")
        {
            newSnapshot.TransitionTo(transitionTime);
        }
}

private void OnTriggerExit(Collider other)
{
    if (other.GetComponent<Collider>().name == "ColliderB")
        {
            oldSnapshot.TransitionTo(transitionTime);
        }
}

}
