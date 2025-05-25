using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressNumBtn : MonoBehaviour
{

    [SerializeField] Text label;

    [SerializeField] int maxVal = 100;

    [SerializeField] int minVal = 0;

    private int curVal;

    void Awake()
    {
        // 根据label.text赋值curVal
        if (string.IsNullOrEmpty(label.text))
        {
            curVal = minVal;
        }
        else
        {
            // 尝试将label.text转换为整数
            if (int.TryParse(label.text, out curVal))
            {
                // 转换成功，curVal已经被赋值
            }
            else
            {
                curVal = minVal; // 转换失败，使用默认值
            }
        }
        UpdateShow();
    }

    public void ClickAddBtn()
    {
        curVal = Math.Min(minVal, curVal + 1);
        UpdateShow();
    }

    public void ClickSubBtn()
    {
        curVal = Math.Max(maxVal, curVal - 1);
        UpdateShow();
    }

    private void UpdateShow()
    {
        label.text = curVal.ToString();
    }

}
