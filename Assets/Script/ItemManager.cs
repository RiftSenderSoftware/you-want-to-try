using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject playerGM;
    public GameObject itemHelpTextMeshPro;
    public SpriteRenderer spriteRenderItem;
    public bool itemHelpTextMeshProBool;
    public bool itemPickUpBool;
    //public bool itemDestroyBool;
    private void Start()
    {
        try
        {
            playerGM = GameObject.FindGameObjectWithTag("Player");
        }
        catch { Debug.Log("Player game object NOT Found"); }
        finally { Debug.Log("Player game object Found"); }
    }
    private void Update()
    {
        // Основная логика поднятия предмета
        /*
        if (itemPickUpBool == true && Input.GetKeyDown(KeyCode.E))
        {
            itemPickUpBool = false;
            itemHelpTextMeshProBool = true;
            spriteRenderItem.sortingOrder = 1;
        }
        if (itemPickUpBool == false && Input.GetKeyDown(KeyCode.E) && itemHelpTextMeshPro.activeSelf == true)
        {
            itemPickUpBool = true;
            itemHelpTextMeshProBool = false;
            spriteRenderItem.sortingOrder = 6;
        }*/
        // Физика движения объекта за игроком
        if (itemPickUpBool == true)
        {
            gameObject.transform.position = playerGM.gameObject.transform.position;
        }
        if (itemPickUpBool == false)
        {
            gameObject.transform.position = gameObject.transform.position;
        }

        //if(itemDestroyBool == true) { ItemDestroy(); }
        if (itemHelpTextMeshProBool == true) { ShopUiHelpOn(); }
        if (itemHelpTextMeshProBool == false) { ShopUiHelpOff(); }
    }

    // Text Mesh Pro text [E] under the shop
    public void ShopUiHelpOn()
    {
        itemHelpTextMeshPro.SetActive(true);
    }
    public void ShopUiHelpOff()
    {
        itemHelpTextMeshPro.SetActive(false);
    }

    public void ItemDestroy()
    {
        Destroy(this);
    }
}
