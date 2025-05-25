using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginPage : BasePage
{

    public override void Close()
    {
        base.Close();
        PageManager.Instance.CreatePage<MainPage>(AAConst.MainPage);
    }

}
