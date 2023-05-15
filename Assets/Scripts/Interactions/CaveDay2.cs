using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveDay2 : MonoBehaviour, IAction
{
    public FadeToBlack fade;

    public async void Activate()
    {
        fade.StartFade();
        await Task.Delay(1500);
        SceneManager.LoadScene("CaveDay2");
    }
}