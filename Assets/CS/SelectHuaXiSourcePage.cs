using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHuaXiSourcePage : BasePage
{
     public void OpenHuaShanData()
    {
        // mainPage.OpenProjectChartPage();
        print("再添加华山医院数据");
        base.Close();
        PageManager.Instance.CreatePage<SelectHuaShanSourcePage>(AAConst.SelectHuaShanSourcePage);
    }
}
