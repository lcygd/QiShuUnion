using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 挂载在MyResourcePanel上
public class MyResourcePanel : PanelBase
{
    public void OpenMyResourcePage()
    {
        PageManager.Instance.CreatePage<AddMyResourcePage>(AAConst.AddMyResourcePage);
    }
}