using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingProcessItem : MonoBehaviour
{

    [SerializeField] private Text text;
    [SerializeField] private Image img;

    private Color buleColor = new Color(63 / 256f, 115 / 256f, 245 / 256f);

    private Color noSelectColor = new Color(234 / 256f, 242 / 256f, 245 / 256f);

    public void SetSelect(bool isSelect)
    {
        text.color = isSelect ? Color.white : buleColor;
        img.color = isSelect ? buleColor : noSelectColor;
    }

}
