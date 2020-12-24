using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RowController : MonoBehaviour
{

    TextMeshProUGUI Text;
    Calculator cal = new Calculator();
    public void CreateRow1(GameObject button, GameObject panel, GameObject operator_button, List<char> list)
    {
        //TextMeshProUGUI Text;
        foreach (char value in list)
        {

            if (char.IsDigit(value))
            {
                GameObject newButton1 = Instantiate(button) as GameObject;
                Text = newButton1.GetComponentInChildren<TextMeshProUGUI>();
                Text.text = value.ToString();
                newButton1.transform.SetParent(panel.transform, false);
                continue;
            }

            GameObject newOperatorButton1 = Instantiate(operator_button) as GameObject;
            Text = newOperatorButton1.GetComponentInChildren<TextMeshProUGUI>();
            Text.text = value.ToString();
            newOperatorButton1.transform.SetParent(panel.transform, false);


        }


    }
    public void CreateRow4(GameObject button, GameObject panel, GameObject operator_button, GameObject clear_button, GameObject result_button, List<char> list)
    {
        // TextMeshProUGUI Text;


        GameObject newButton4 = Instantiate(button) as GameObject;
        Text = newButton4.GetComponentInChildren<TextMeshProUGUI>();
        Text.text = list[0].ToString();
        newButton4.transform.SetParent(panel.transform, false);

        GameObject newClearButton4 = Instantiate(clear_button) as GameObject;
        Text = newClearButton4.GetComponentInChildren<TextMeshProUGUI>();
        Text.text = list[1].ToString();
        newClearButton4.transform.SetParent(panel.transform, false);

        GameObject newResultButton4 = Instantiate(result_button) as GameObject;
        Text = newResultButton4.GetComponentInChildren<TextMeshProUGUI>();
        Text.text = list[2].ToString();
        newResultButton4.transform.SetParent(panel.transform, false);

        GameObject newOperatorButton4 = Instantiate(operator_button) as GameObject;
        Text = newOperatorButton4.GetComponentInChildren<TextMeshProUGUI>();
        Text.text = list[3].ToString();
        newOperatorButton4.transform.SetParent(panel.transform, false);
    }


}
