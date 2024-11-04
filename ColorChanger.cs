using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{

    public Renderer HairObjectRenderer;
    public Texture[] HairTextures;
    public int HairIndex;

    public Button HairLeftButton;
    public Button HairRightButton;
    // Start is called before the first frame update
    void Start()
    {
        if (HairObjectRenderer != null && HairTextures.Length > 0)
        {
            HairObjectRenderer.material.mainTexture = HairTextures[HairIndex];
        }
        HairLeftButton.onClick.AddListener(ChangehairTextureLeft);
        HairRightButton.onClick.AddListener(ChangehairTextureRight);
    }
    public void ChangehairTextureLeft()
    {
        HairIndex--;
        if(HairIndex < 0)
        {
            HairIndex = HairTextures.Length - 1;
        }
        UpdatehairTexture();
    }
    public void ChangehairTextureRight()
    {
        HairIndex++;
        if (HairIndex >= 0)
        {
            HairIndex = 0;
        }
        UpdatehairTexture();
    }
    public void UpdatehairTexture()
    {
        HairObjectRenderer.material.mainTexture = HairTextures[HairIndex];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
