using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RestaUI : MonoBehaviour
{
    public TMP_InputField input_num1;
    public TMP_InputField input_num2;
    public TextMeshProUGUI txt_Resultado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void ShowNumSquare ()
   {
    int num1 =  int.Parse(input_num1.text);
    int num2= int.Parse (input_num2.text);
    txt_Resultado.text = (num1 - num2).ToString();

    if (num1 - num2 <0){
        txt_Resultado.text = "error";
    }
   }
}
