using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour, IAction
{
    public GameObject diaryUI;

    public void Activate()
    {
            diaryUI.SetActive(true);
    }
}
