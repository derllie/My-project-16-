using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneSc : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    public PlayableDirector cameraTimeline; // Переменная для хранения анимации камеры

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
        cameraTimeline.Play(); // Запуск анимации камеры

        StartCoroutine(FinishCut());
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(1);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
        yield return new WaitForSeconds(5);
        cutsceneCam.SetActive(true);
    }
}



