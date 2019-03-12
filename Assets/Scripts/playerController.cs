using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public Text endText;

    void Start()
    {
        endText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb 1"))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        endText.text = "You Died!";
    }
}
