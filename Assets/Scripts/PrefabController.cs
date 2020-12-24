using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    
    public GameObject panel_1;
    public GameObject Panel_2;
    public GameObject panel_3;
    public GameObject Panel_4;
    public GameObject button;
    public GameObject operator_button;
    public GameObject Clear_button;
    public GameObject Result_button;
    public TextMeshProUGUI Input;
    public List<char> row1List;
    public List<char> row2List;
    public List<char> row3List;
    public List<char> row4List;
    // public TextMeshProUGUI Text;

    public void Start()
    {
        
        RowController row1 = new RowController();
        row1.CreateRow1(button,panel_1,operator_button,row1List);
        row1.CreateRow1(button,Panel_2,operator_button,row2List);
        row1.CreateRow1(button,panel_3,operator_button,row3List);
        row1.CreateRow4(button,Panel_4,operator_button,Clear_button,Result_button,row4List);
       
       
    }
}
