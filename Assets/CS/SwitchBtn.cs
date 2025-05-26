using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBtn : MonoBehaviour
{
    [SerializeField] Image onImage;

    [SerializeField] private bool isOn;
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.RemoveAllListeners(); // 先移除
        button.onClick.AddListener(OnClick);    // 再添加
    }

    public void OnClick()
    {
        isOn = true;
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
