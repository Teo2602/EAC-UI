using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SumayResultado : MonoBehaviour
{
    public TMP_InputField Num1;
    public TMP_InputField Num2;
    public TextMeshProUGUI txtmensage;
    // Start is called before the first frame update
    void Start()
    {
        txtmensage.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sumar()
    {
        int num1 = int.Parse(Num1.text);
        int num2 = int.Parse(Num2.text);
        Debug.Log("sumar");
        if (num2 == 0)
        {
            txtmensage.text = "El número dos no puede ser 0";
            return;
        }
        else{
            txtmensage.text = $"{num1}/{num2}={num1 / num2}";
        }
    }
}
