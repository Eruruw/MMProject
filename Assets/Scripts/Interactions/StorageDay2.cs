using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageDay2 : MonoBehaviour, IAction
{
    public GameObject sack;
    public GameObject eventUI;
    public GameObject monster;

    public void Activate()
    {
        sack.SetActive(true);
        eventUI.SetActive(true);
        monster.SetActive(true);
    }
}