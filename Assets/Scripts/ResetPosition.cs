using cowsins;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    [SerializeField] Transform targetPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) other.transform.position = targetPosition.transform.position;
        

    }
}
