using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class CameraFilter : MonoBehaviour
{
    public enum FilterType
    {
        None,
        Red,
        Green,
        Blue
    }

    public FilterType filterType;
    public Material filterMaterial;

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (filterType == FilterType.None)
        {
            Graphics.Blit(source, destination);
        }
        else
        {
            Graphics.Blit(source, destination, filterMaterial);
        }
    }
}