using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnionPage : MonoBehaviour
{

    [SerializeField] private List<PanelBase> panels;

    [SerializeField] private List<TagItem> tagItems;

    [SerializeField] private RectTransform tagListContent;

    private int index;

    void Start()
    {
        TagItemSelect(tagItems[0]);
    }

    public void TagItemSelect(TagItem selectItem)
    {
        index = tagItems.IndexOf(selectItem);
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
        int panelIndex = index + tagItem.subIndex;
        for (int i = 0; i < panels.Count; i++)
        {
            panels[i].gameObject.SetActive(i == panelIndex);
        }
    }


}
