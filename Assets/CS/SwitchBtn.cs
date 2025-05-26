using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBtn : MonoBehaviour
{
    [SerializeField] Image onImage;

    [SerializeField] private bool isOn;

    public void OnClick()
    {
        isOn = !isOn;
        UpdateShow();
    }

    public void UpdateShow()
    {
        onImage.gameObject.SetActive(isOn);
    }

    // 在编辑器模式下修改值时调用UpdateShow
    // private void OnValidate()
    // {
    //     UpdateShow();
    // }


}
