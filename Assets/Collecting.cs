using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    private int Coin = 0;


    public TextMeshProUGUI coinText;




    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "coin")
        {
            Coin++;
            coinText.text = "Keys: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
            AudioManager.instance.PlaySFX("Coin");

        }
    }
}
