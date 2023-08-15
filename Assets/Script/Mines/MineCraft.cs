using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCraft : MonoBehaviour
{
    public bool mineInstantiateBool;

    public GameObject prefabMine;
    public GameObject mineHelpTextMeshPro;
    public bool mineHelpTextMeshProBool;

    private void Update()
    {
        // Debag close interface
        if (Input.GetKeyDown(KeyCode.E))
        {
            mineInstantiateBool = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && mineHelpTextMeshPro.activeSelf == true)
        {
            mineInstantiateBool = true;

        }


        if (mineInstantiateBool == true) { MineSpawn(); }

        if (mineHelpTextMeshProBool == true) { ShopUiHelpOn(); }
        if (mineHelpTextMeshProBool == false) { ShopUiHelpOff(); }
    }
    // Open main shop canvas
    public void MineSpawn()
    {
        Instantiate(prefabMine);
        prefabMine.gameObject.GetComponent<Rigidbody>().AddForce(Vector2.down);
        mineInstantiateBool = false;
    }



    // Text Mesh Pro text [E] under the shop
    public void ShopUiHelpOn()
    {
        mineHelpTextMeshPro.SetActive(true);
    }
    public void ShopUiHelpOff()
    {
        mineHelpTextMeshPro.SetActive(false);
    }
}
