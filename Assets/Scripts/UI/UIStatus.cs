using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Button backBtn;
    void Start()
    {
        backBtn.onClick.AddListener(Back);
    }

    void Back()
    {
        UIManager.Instance.Back();
    }

   
}
