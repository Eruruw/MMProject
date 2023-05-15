using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour, IAction
{
    public GameObject sack;
    public GameObject eventUI;

    public void Activate()
    {
        sack.SetActive(true);
        eventUI.SetActive(true);
    }
}
