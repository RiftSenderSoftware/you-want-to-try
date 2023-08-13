using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject shopUIMenu;
    public bool shopUIMenuBool;

    public GameObject shopHelpTextMeshPro;
    public bool shopHelpTextMeshProBool;

    private void Update()
    {
        // Debag close interface
        if (shopUIMenu.activeSelf == true && Input.GetKeyDown(KeyCode.E))
        {
            shopUIMenuBool = false;
        }
        if (shopUIMenu.activeSelf == false && Input.GetKeyDown(KeyCode.E) && shopHelpTextMeshPro.activeSelf == true)
        {
            shopUIMenuBool = true;

        }


        if (shopUIMenuBool == true) { ShopUIOpen(); }
        if(shopUIMenuBool == false) { ShopUIClose(); }
        if(shopHelpTextMeshProBool == true) { ShopUiHelpOn(); }
        if(shopHelpTextMeshProBool == false) { ShopUiHelpOff(); }
    }
    // Open main shop canvas
    public void ShopUIOpen()
    {
        shopUIMenu.SetActive(true);
        shopUIMenuBool = true;
    }
    public void ShopUIClose()
    {
        shopUIMenu.SetActive(false);
        shopUIMenuBool = false;
    }


    // Text Mesh Pro text [E] under the shop
    public void ShopUiHelpOn()
    {
        shopHelpTextMeshPro.SetActive(true);
    }
    public void ShopUiHelpOff()
    {
        shopHelpTextMeshPro.SetActive(false);
    }
}
