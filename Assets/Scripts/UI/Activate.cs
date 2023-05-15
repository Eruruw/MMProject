using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject eventUI;
    private bool active;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player") && !active)
        {
            active = true;
            eventUI.SetActive(true);
        }
    }
}
