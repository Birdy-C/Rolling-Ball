using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenAdapt : MonoBehaviour {

    public List<CanvasScaler> UICanvas;

    private float diagonalInches;
    private float width;
    private float height;
    private float ypotinousa;
    private float dpi;

    private float screenScale;
    void screenInch()
    {
        dpi = Screen.dpi;
        if (dpi < 25 || dpi > 1000)
        {
            dpi = 150;
        }
        width = Screen.width * Screen.width;
        height = Screen.height * Screen.height;
        ypotinousa = width + height;
        ypotinousa = Mathf.Sqrt(ypotinousa);
        diagonalInches = ypotinousa / Screen.dpi;
    }

    void Awake()
    {
        if (Application.isMobilePlatform)
        {
            screenInch();
            //以五寸屏幕作为标准
            screenScale = diagonalInches / 5f;

            for (int i = 0; i < UICanvas.Count; i++)
            {
                Vector2 _size = UICanvas[i].referenceResolution;
                UICanvas[i].referenceResolution = _size * screenScale;
                if (UICanvas[i].GetComponent<Canvas>().renderMode == RenderMode.ScreenSpaceCamera)
                {
                    UICanvas[i].GetComponent<Canvas>().worldCamera.orthographicSize *= screenScale;
                }
            }
        }
    }

}
