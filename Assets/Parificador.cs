using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parificador : MonoBehaviour
{
    public TMP_InputField Num1;
    public TextMeshProUGUI mensage;
    // Start is called before the first frame update
    void Start()
    {
        mensage.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ispar()
    {
        int num1 = int.Parse(Num1.text);
        int resto = num1 % 2;
        if (num1 < 0)
        {
            mensage.text = "el número debe ser mayor que 0";
            return;
        }
        if (resto == 0)
        {
            mensage.text = "Tu número es par";
        } else
        {
            mensage.text = "Tu número no es par";
        }
    }
}
