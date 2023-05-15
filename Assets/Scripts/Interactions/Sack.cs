using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sack : MonoBehaviour, IAction
{
    public void Activate()
    {
        gameObject.SetActive(false);
    }
}
