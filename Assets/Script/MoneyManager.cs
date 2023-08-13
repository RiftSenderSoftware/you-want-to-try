using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MoneyManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    public int moneyCout;
    public int moneyCoutChange;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = moneyCout.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(moneyCout != moneyCoutChange)
        {
            moneyCout = moneyCoutChange;
            moneyText.text = moneyCout.ToString();
        }

    }
}
