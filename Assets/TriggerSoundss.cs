using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TriggerSoundss : MonoBehaviour
{
    public string sceneToLoad; // Имя сцены, на которую нужно перенести игрока

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Проверяем, что касается именно игрок
        {
            AudioManager.instance.PlayMusic("Dessert"); // Загружаем указаннуюцену
        }
    }
}

