using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TriggerSoundss : MonoBehaviour
{
    public string sceneToLoad; // ��� �����, �� ������� ����� ��������� ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���������, ��� �������� ������ �����
        {
            AudioManager.instance.PlayMusic("Dessert"); // ��������� �������������
        }
    }
}

