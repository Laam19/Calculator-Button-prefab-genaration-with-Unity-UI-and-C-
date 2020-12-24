using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


public class Calculator : MonoBehaviour
{

    public TextMeshProUGUI Input;
    private string _inputString;


    public void ButtonPressed()
    {


        string Value = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(EventSystem.current.currentSelectedGameObject.name); 
        if (Value == "C")
        {
            Input.text = " ";
            _inputString = " ";
        }
        else
        {
            _inputString += Value;
            Input.text = _inputString;
        }


    }
}
