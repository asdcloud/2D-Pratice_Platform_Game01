using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMeshProUGUI textmeshPro;

    void start() {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    void Update() {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.text = "Score: " + scoreValue;
    }
}
