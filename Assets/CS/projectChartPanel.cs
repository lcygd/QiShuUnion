using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectChartPanel : PanelBase
{

    [SerializeField] GameObject startShow;
    [SerializeField] GameObject lastShow;

    // detail相关
    [SerializeField] GameObject detailShow;
    [SerializeField] Image huaxiBtn;
    [SerializeField] Image huashanBtn;
    [SerializeField] GameObject huashanShow;
    [SerializeField] GameObject huashanNew;
    [SerializeField] GameObject huaxiShow;
    [SerializeField] GameObject huaxiNew;

    private bool selecthuaxi = true;
    private bool huaxiPass = false;
    private bool huashanPass = false;


    //打开项目创建页面，也就是最后一个页签，可以调用MainPage里的方法来跳转
    public void OpenCreateProjectPanel()
    {
        // mainPage.OpenProjectChartPage();
        print("打开项目创建页面");
        MainPage.Instance.OpenCreateProjectPanel();
    }

    public override void OnShow()
    {
        bool isCreateEnd = DataManager.Instance.isCreateEnd;
        startShow.SetActive(!isCreateEnd);
        lastShow.SetActive(isCreateEnd);
        detailShow.SetActive(false);
    }

    #region detail 相关

    public void ShowDetail()
    {
        startShow.SetActive(false);
        lastShow.SetActive(false);
        detailShow.SetActive(true);
    }


    public void HideDetail()
    {
        OnShow();
    }

    private void UpdateDetailShow()
    {
        huaxiBtn.color = new Color(1, 1, 1, selecthuaxi ? 1 : 0);
        huaxiShow.SetActive(selecthuaxi && !huaxiPass);
        huaxiNew.SetActive(selecthuaxi && huaxiPass);

        huashanBtn.color = new Color(1, 1, 1, selecthuaxi ? 0 : 1);
        huashanShow.SetActive(selecthuaxi && !huashanPass);
        huashanNew.SetActive(selecthuaxi && huashanPass);
    }

    public void OnClickHuaxiBtn()
    {
        selecthuaxi = true;
        UpdateDetailShow();
    }


    public void OnClickHuashanBtn()
    {
        selecthuaxi = false;
        UpdateDetailShow();
    }

    public void OnClickHuaxiPassBtn()
    {
        huaxiPass = true;
        UpdateDetailShow();
    }


    public void OnClickHuashanPassBtn()
    {
        huashanPass = true;
        UpdateDetailShow();
    }

    #endregion detail 相关


}
