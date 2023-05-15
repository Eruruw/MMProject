using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public FadeToBlack fade;
    public GameObject cam;
    public bool end;
    private bool pressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !pressed)
        {
            pressed = true;
            fade.StartFade();
            ChangeActiveCam();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && end)
        {
            Application.Quit();
        }
    }

    public async void ChangeActiveCam()
    {
        await Task.Delay(1500);
        gameObject.SetActive(false);
        cam.SetActive(true);
        fade.StopFade();
        end = true;
    }
}
