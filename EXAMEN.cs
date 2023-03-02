using System.Collections;
using System.Collections.Generic;
using UnityEngine.EsceneManagement;
using TMPro;


int azar1;
int azar2;
int pc;
int respSuma = azar1 + azar2;
int usuario;
int respUsu;
[SerializeField] Private TMP_Text textPC;
[SerializeField] Private TMP_Text  textUSU;

public class EXAMEN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int azar1 = Random.Range(1, 11);
        int azar2 = Random.Range(1, 11);
        textPC = "PC: YA ELEGI MIS 2 NUMEROS:";
    }
    // Update is called once per frame
    void Update()
    {

    }

    void InputRespuestaUsu(int miRespuesta )
    {
        usuario = miRespuesta;
        textUSU = "MI RESPUESTA ES:"; respUsu;
    }

    void Resultados(int respEcuacionSuma)
    {
        pc = respEcuacionSuma;
        if (respSuma == respUsu) { textPC = "LA RESPUESTA ES CORRECTA"; }
         else { textPC = "LA RESPUESTA ES INCORRECTA"; }

    }
}
