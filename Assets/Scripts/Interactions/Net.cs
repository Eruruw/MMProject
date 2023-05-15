using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Net : MonoBehaviour , IAction
{
    public GameObject netMesh1;
    public GameObject netMesh2;
    public GameObject fish1;
    public GameObject fish2;
    public GameObject fish3;
    public GameObject fish4;
    public GameObject sack;
    public GameObject catchUI;
    public GameObject doneUI;
    private int fish = 0;

    public async void Activate()
    {
        // play sound
        netMesh1.SetActive(false);
        netMesh2.SetActive(false);
        await Task.Delay(2000);
        if (fish == 0)
        {
            fish1.SetActive(true);
            catchUI.SetActive(true);
        }
        else if (fish == 1)
        {
            fish2.SetActive(true);
            catchUI.SetActive(true);
        }
        else if (fish == 2)
        {
            fish3.SetActive(true);
            catchUI.SetActive(true);
        }
        else if (fish == 3)
        {
            fish4.SetActive(true);
            catchUI.SetActive(true);
        }
        else if (fish == 4)
        {
            fish1.SetActive(false);
            fish2.SetActive(false);
            fish3.SetActive(false);
            fish4.SetActive(false);
            sack.SetActive(true);
            doneUI.SetActive(true);
        }
        fish += 1;
        netMesh1.SetActive(true);
        netMesh2.SetActive(true);
        // play sound
    }
}
