using UnityEngine;
using UnityEngine.UI;

public class FileUploader : MonoBehaviour
{
    // [SerializeField] Button uploadButton;
    
    // void Start()
    // {
    //     uploadButton.onClick.AddListener(OnUploadClick);
    // }

    public void OnUploadClick()
    {
#if UNITY_STANDALONE_WIN || UNITY_EDITOR_WIN
        string targetPath = @"D:\contest\Qishu\Assets\data";
        
        // 可选：在编辑器中转换为相对路径
        // targetPath = System.IO.Path.Combine(Application.dataPath, "data");
        
        string selectedFile = WindowsFileDialog.ShowOpenDialog(
            initialDir: targetPath,
            title: "Select Excel File",
            filter: "Excel Files\0*.xlsx;*.xls\0All Files\0*.*\0\0"
        );

        if (!string.IsNullOrEmpty(selectedFile))
        {
            Debug.Log("Selected file: " + selectedFile);
            // 在这里处理选中的文件
            transform.Find("Content/ShowContent/Upload/uploaded")?.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("File selection cancelled");
        }
#else
        Debug.LogWarning("File dialog only supported on Windows platform");
#endif
    }
}