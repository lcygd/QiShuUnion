using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagItem : MonoBehaviour
{

    [SerializeField] private MainPage unionPage;

    [SerializeField] private Image mainIcon;

    [SerializeField] private Text mainText;

    [SerializeField] private Image arrow;

    [SerializeField] private Image bg;

    [SerializeField] private List<TagSubItem> tagSubItems;

    public bool isSelected = false;

    public int subIndex;

    public void OnClick()
    {
        print("点击率tagItem!");
        unionPage.TagItemSelect(this);
    }

    public void TagSubItemSelect(TagSubItem subItem)
    {
        subIndex = tagSubItems.IndexOf(subItem);
        for (int i = 0; i < tagSubItems.Count; i++)
        {
            tagSubItems[i].UpdateShow(subIndex == i);
        }
        unionPage.UpdatePanelsShow();
    }

    public void SetSelect(bool isSelected)
    {
        this.isSelected = isSelected;
        arrow.transform.rotation = new Quaternion(0, 0, isSelected ? 0 : 180, 0);
        arrow.color = isSelected ? Color.white : Color.gray;
        mainIcon.color = isSelected ? Color.white : Color.gray;
        mainText.color = isSelected ? Color.white : Color.gray;
        bg.gameObject.SetActive(isSelected);
        for (int i = 0; i < tagSubItems.Count; i++)
        {
            tagSubItems[i].UpdateShow(subIndex == i);
        }
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());

    }

}
