using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateProjectPanel : PanelBase
{

    public static CreateProjectPanel Instance { get; private set; }

    [SerializeField] private GameObject detail;

    void Awake()
    {
        if(Instance == null) Instance = this;
        detail.SetActive(false);
    }

    public void ShowXieHeData()
    {
        print("显示添加的发起方-协和数据");
    }

    public void ShowCooperateData()
    {
        print("显示添加的协作方-华西华山数据");
    }
    //添加发起方数据，打开SelectXieHeSourcePanel，选择增加以后再ShowXieHeData
    public void AddLauncherData()
    {
        print("添加发起方数据");
        PageManager.Instance.CreatePage<SelectXieHeSourcePage>(AAConst.SelectXieHeSourcePage);

    }

    //添加协作方。
    public void AddCooperator()
    {
        // mainPage.OpenProjectChartPage();
        print("添加协作方");
        PageManager.Instance.CreatePage<SelectNumberPanel>(AAConst.SelectNumberPanel);
    }

     //添加协作方数据，先打开华西医院的数据列表，选择添加以后再打开华山数据列表，在华山数据列表里再显示ShowCooperateData
    public void AddCooperatorData()
    {
        // mainPage.OpenProjectChartPage();
        print("先添加华西医院数据");
        PageManager.Instance.CreatePage<SelectHuaXiSourcePage>(AAConst.SelectHuaXiSourcePage);
    }

    public void ShowSelectCooperateData()
    {
        transform.Find("cooporate_data")?.gameObject.SetActive(true);
    }

    public void ShowSelectLaunchData()
    {
        transform.Find("xiehe_data")?.gameObject.SetActive(true);
    }

    public void ShowResultData()
    {
        detail.SetActive(true);
    }
}
