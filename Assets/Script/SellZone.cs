using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SellZone : MonoBehaviour
{
    public MoneyManager mm;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log("Destroy");
            mm.moneyCoutChange += 5;
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log("Destroy");

            mm.moneyCoutChange += 5;
            Destroy(collision.gameObject);
        }
    }
}
