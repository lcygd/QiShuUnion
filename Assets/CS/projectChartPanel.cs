using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectChartPanel : PanelBase
{
    //打开项目创建页面，也就是最后一个页签，可以调用MainPage里的方法来跳转
    public void OpenCreateProjectPanel()
    {
        // mainPage.OpenProjectChartPage();
        print("打开项目创建页面");
        MainPage.Instance.OpenCreateProjectPanel();
    }
}
