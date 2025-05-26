using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHuaShanSourcePage : BasePage
{
    public void AchieveCooperate()
    {
        base.Close();
        CreateProjectPanel.Instance.ShowSelectCooperateData();
    }
}
