using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 页面基类，提供页面初始化和关闭的接口
/// </summary>
public abstract class BasePage : MonoBehaviour
{

    // 对应PageManager中的cache
    private string key;

    /// <summary>
    /// 页面初始化方法，在页面创建时调用
    /// </summary>
    public void OnInit(string key)
    {
        this.key = key;
        isInitialized = true;
        Init();
    }

    /// <summary>
    /// 页面关闭方法，在页面销毁时调用
    /// </summary>
    public void OnClose()
    {

    }

    /// <summary>
    /// 页面是否已初始化
    /// </summary>
    protected bool isInitialized = false;

    /// <summary>
    /// Unity的OnDestroy方法，自动调用OnClose
    /// </summary>
    protected virtual void OnDestroy()
    {
        OnClose();
    }

    /// <summary>
    /// 页面显示
    /// </summary>
    public virtual void Init()
    {

    }

    /// <summary>
    /// 关闭当前页面
    /// </summary>
    public virtual void Close()
    {
        PageManager.Instance.DestroyPage(key);
    }
}
