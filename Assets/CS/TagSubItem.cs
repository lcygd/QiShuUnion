using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TagSubItem : MonoBehaviour
{

    [SerializeField] private Image selectBg;

    [SerializeField] private Text subText;

    [SerializeField] private TagItem tagItem;

    [SerializeField] private int index;


    public void OnClick()
    {
        tagItem.TagSubItemSelect(this);
        Debug.Log("TagSubItem OnClick");
    }

    public void UpdateShow(bool isSelected)
    {
        if (!tagItem.isSelected)
        {
            gameObject.SetActive(false);
            return;
        }
        gameObject.SetActive(true);
        selectBg.gameObject.SetActive(isSelected);
        subText.color = isSelected ? Color.white : Color.gray;
    }


}
