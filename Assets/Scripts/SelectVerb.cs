using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectVerb : MonoBehaviour
{
    public List<GameObject> Buttons = new List<GameObject>();

    public List<GameObject> Models = new List<GameObject>();

    GameObject LastBtn;

    int LastID = -1;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeModel(int i)
    {
        if (LastID != -1)
        {
            Models[LastID].SetActive(false);
            Buttons[LastID].GetComponent<Image>().color = new Color(0.3419811f, 0.5f, 0.4642221f);

        }
        LastID = i;
        LastBtn = Buttons[i];
        ChangeBtn(LastBtn);
        Models[i].SetActive(true);
    }

    void ChangeBtn(GameObject Btn)
    {
        Btn.transform.GetComponent<Image>().color = new Color(0.2070577f, 0.3113208f, 0.2858907f);
    }
}
