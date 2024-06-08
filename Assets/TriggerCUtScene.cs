using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerCUtScene : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;
    // Переменная для хранения анимации камеры

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        cutsceneCam.SetActive(true);
        thePlayer.SetActive(false);
       // Запуск анимации камеры

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

