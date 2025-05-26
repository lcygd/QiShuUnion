using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPage : BasePage
{

    [SerializeField] private List<PanelBase> panels;

    [SerializeField] public  List<TagItem> tagItems;

    [SerializeField] private RectTransform tagListContent;

    private int index;
    private bool isCreateProjectPanel = false;

    public static MainPage Instance { get; private set; }

    void Awake()
    {
        if(Instance == null) Instance = this;
    }

    void Start()
    {
        TagItemSelect(tagItems[0]);
    }

    public void TagItemSelect(TagItem selectItem)
    {
        index = tagItems.IndexOf(selectItem);
        Debug.LogError("现在点击的TagItem的索引是："+index);
        for (int i = 0; i < tagItems.Count; i++)
        {
            tagItems[i].SetSelect(selectItem == tagItems[i]);
        }
        LayoutRebuilder.ForceRebuildLayoutImmediate(tagListContent);
        UpdatePanelsShow();
    }

    public void UpdatePanelsShow()
    {
        TagItem tagItem = tagItems[index];
        Debug.LogError("tagItem.subIndex="+tagItem.subIndex);
        if (isCreateProjectPanel==true)
        {
            tagItem.subIndex = 1;
            isCreateProjectPanel = false;
        }
        int panelIndex = index == 0 ? 0 : index + tagItem.subIndex + index - 1;
        for (int i = 0; i < panels.Count; i++)
        {
            print(i);
            print(panelIndex);
            if(i == panelIndex)
            {
                Debug.LogError("显示："+panels[i].gameObject.name);
            }
            else
            {
                Debug.LogError("不显示："+panels[i].gameObject.name);
            }
            panels[i].gameObject.SetActive(i == panelIndex);
        }
    }
    public void OpenCreateProjectPanel()
    {
        isCreateProjectPanel = true;
        TagItemSelect(tagItems[2]);
    }


}
