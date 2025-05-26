using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingProcessPage : BasePage
{

    private int progress = 0;

    [SerializeField] private List<GameObject> progressItems;
    [SerializeField] private List<TrainingProcessItem> progressItemBtns;

    [SerializeField] private GameObject progressContent;
    [SerializeField] private GameObject startContent;

    public override void Init()
    {
        base.Init();
        progress = 0;
        UpdateBtnShow();
        progressContent.SetActive(true);
        startContent.SetActive(false);
    }

    private void UpdateShow()
    {
        for (int i = 0; i < progressItems.Count; i++)
        {
            progressItems[i].SetActive(i == progress);
        }
    }

    private void UpdateBtnShow()
    {
        for (int i = 0; i < progressItemBtns.Count; i++)
        {
            var isSelect = false;
            if (i == 0)
            {
                isSelect = progress == 1 || progress == 2;
            }
            else
            {
                isSelect = progress == i + 2;
            }
            progressItemBtns[i].SetSelect(isSelect);
        }
        UpdateShow();
    }

    #region 按钮点击

    public void OnClickProgress1()
    {
        progress = 1;
        UpdateBtnShow();
    }


    public void OnClickProgress3()
    {
        progress = 3;
        UpdateBtnShow();
    }


    public void OnClickProgress4()
    {
        progress = 4;
        UpdateBtnShow();
    }

    public void OnClickProgress5()
    {
        progress = 5;
        UpdateBtnShow();
    }

    public void OnClickProgress6()
    {
        progress = 6;
        UpdateBtnShow();
    }

    public void OnClickPlayBtn()
    {
        progressContent.SetActive(false);
        startContent.SetActive(true);
    }

    #endregion

}
