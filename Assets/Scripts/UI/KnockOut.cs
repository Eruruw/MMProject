using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnockOut : MonoBehaviour
{
    public FadeToBlack fade;
    public AudioClip audio;
    private bool played;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !played)
        {
            played = true;
            GameObject player = GameObject.FindWithTag("Player");
            Transform tf = player.GetComponent<Transform>();
            AudioSource.PlayClipAtPoint(audio, new Vector3(tf.position.x, tf.position.y, tf.position.z));
            fade.CutFade();
            ChangeScene();
            gameObject.SetActive(false);
        }
    }

    private async void ChangeScene()
    {
        await Task.Delay(1500);
        SceneManager.LoadScene("Day2FromCave");
    }
}
