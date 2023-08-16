using System.Collections;
using UnityEngine;

public class AngryBirdChecker : MonoBehaviour
{
    private bool isOnGround = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            isOnGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ground"))
        {
            isOnGround = false;
        }
    }

    public bool IsAngryBirdOnGround()
    {
        return isOnGround;
    }
}