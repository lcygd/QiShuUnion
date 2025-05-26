using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    // 单例实例
    private static PageManager _instance;
    public static PageManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<PageManager>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject("PageManager");
                    _instance = obj.AddComponent<PageManager>();
                    DontDestroyOnLoad(obj); // 跨场景不销毁
                }
            }
            return _instance;
        }
    }

    public Transform pageContainer; // 存放页面的容器
    private Dictionary<string, GameObject> pageCache = new Dictionary<string, GameObject>(); // 缓存已加载的页面

    void Start()
    {
        CreatePage<LoginPage>(AAConst.LoginPage);
    }

    /// <summary>
    /// 通过路径创建页面
    /// </summary>
    public void CreatePage<T>(string prefabPath) where T : BasePage
    {
        if (pageContainer == null)
        {
            Debug.LogError("Page container is not set!");
            return;
        }

        // 检查缓存中是否已存在该页面
        if (pageCache.ContainsKey(prefabPath))
        {
            Debug.LogWarning($"Page {prefabPath} is already loaded.");
            return;
        }

        // 从 Resources 文件夹加载预制体
        // string fullPath = AssetDatabase.GetAssetPath(prefabPath);
        // if (string.IsNullOrEmpty(fullPath))
        // {
        //     Debug.LogError($"Invalid asset path: {prefabPath}");
        //     return;
        // }


        // 实例化页面并设置名称（移除路径前缀和后缀）
        string pageName = prefabPath.Replace("Assets/Resources/", "").Replace(".prefab", "");


        GameObject prefab = Resources.Load<GameObject>(pageName);
        if (prefab == null)
        {
            Debug.LogError($"Failed to load prefab at path: {prefabPath}");
            return;
        }

        GameObject newPage = Instantiate(prefab, pageContainer);
        newPage.name = pageName;

        // 获取页面组件并初始化
        T page = newPage.GetComponent<T>();
        if (page != null)
        {
            page.OnInit(prefabPath);
        }
        else
        {
            Debug.LogError($"Failed to get {typeof(T)} component from prefab: {prefabPath}");
            Destroy(newPage);
            return;
        }

        // 缓存页面
        pageCache.Add(prefabPath, newPage);
    }
    /// <summary>
    /// 销毁指定路径的页面
    /// </summary>
    public void DestroyPage(string prefabPath)
    {
        if (pageCache.TryGetValue(prefabPath, out GameObject page))
        {
            page.GetComponent<BasePage>().OnClose();
            Destroy(page);
            pageCache.Remove(prefabPath);
        }
        else
        {
            Debug.LogWarning($"Page {prefabPath} not found in cache.");
        }
    }

    /// <summary>
    /// 销毁所有页面
    /// </summary>
    public void DestroyAllPages()
    {
        foreach (var page in pageCache.Values)
        {
            Destroy(page);
        }
        pageCache.Clear();
    }
}
