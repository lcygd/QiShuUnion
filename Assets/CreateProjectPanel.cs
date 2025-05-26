using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateProjectPanel : BasePage
{
    //添加发起方数据，打开SelectXieHeSourcePanel
    public void AddLauncherData()
    {
        print("添加发起方数据");
        PageManager.Instance.CreatePage<SelectXieHeSourcePage>(AAConst.SelectXieHeSourcePage);

    }

     //添加协作方数据
    public void AddCooperatorData()
    {
        // mainPage.OpenProjectChartPage();
        print("添加协作方数据");
    }
}
