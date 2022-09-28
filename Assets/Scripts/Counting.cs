using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counting : MonoBehaviour
{

    private int zahl;

    public Text startnumber;
    public InputField BasePrice;
    public InputField SellingPrice;


    private void Update()
    {
        startnumber.text = zahl.ToString();
    }

    public void onButtonClickPlus()
    {
        zahl++;
    }

    public void onButtonClickMinus()
    {
        zahl--;
    }

    

}
