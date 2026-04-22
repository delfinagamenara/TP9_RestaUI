using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuadradoUI : MonoBehaviour
{
    public TMP_InputField input_num1;
    public TextMeshProUGUI txt_Resultado;


    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void ShowNumSquare ()
   {
    int num1 =  int.Parse(input_num1.text);
    txt_Resultado.text = (num1 * num1).ToString();

   }
}
