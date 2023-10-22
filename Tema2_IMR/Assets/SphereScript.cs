using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public int puncteDeScor = 10; // Punctele câștigate pentru fiecare lovitură

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            // Obține distanța dintre sferă și țintă
            float distanta = Vector3.Distance(transform.position, collision.transform.position);

            // Calculează punctele în funcție de distanță (poți ajusta această formulă în funcție de preferințele tale)
            int puncteCastigate = Mathf.RoundToInt(100f / distanta);

            // Obține script-ul țintei și apelează metoda CresteScor pentru a crește scorul
            TargetScript targetScript = collision.gameObject.GetComponent<TargetScript>();
            if (targetScript != null)
            {
                targetScript.CresteScor(puncteCastigate);
            }

            // Dezactivează sfera pentru a o face să dispară după ce lovește ținta
            gameObject.SetActive(false);
        }
    }

}
