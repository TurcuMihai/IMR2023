using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // Asigură-te că ai importat namespace-ul UnityEngine.UI
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public Text textScore; // Asigură-te că ai asocierile făcute în Editorul Unity

    private int scor = 0;

    public void CresteScor(int puncte)
    {
        scor += puncte;
        textScore.text = "Scor: " + scor; // Actualizează textul scorului pe ecran
    }
}
