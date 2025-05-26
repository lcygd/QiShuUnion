using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectXieHeSourcePage : BasePage
{
    public void AchieveLauncher()
    {
        base.Close();
        CreateProjectPanel.Instance.ShowSelectLaunchData();
    }
}
