using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour
{

    public GameObject Cell;
    public GameObject UIInventory;
 
    public List<GameObject> personClothesCanBeOnPerson = new List<GameObject>(6);
    /*
        Element 0 - Cloth_up,
        Element 1 - Cloth_down,
        Element 2 - Cloth_helmet,
        Element 3 - Left_arm,
        Element 4 - Right_arm,
        Element 5 - Bag
     */

    // Gameobjects person Clothes (GameObjects)
    public List<GameObject> personPrefabsClothesOnPerson = new List<GameObject>(6);
    /*
        Element 0 - PrefabsCloth_up,
        Element 1 - PrefabsCloth_down,
        Element 2 - PrefabsCloth_helmet,
        Element 3 - PrefabsLeft_arm,
        Element 4 - PrefabsRight_arm,
        Element 5 - PrefabsBag
     */


    // Cloth parameter for person
    public bool DressedCloth_up = false;
    public bool DressedCloth_down = false;
    public bool DressedHelmet = false;
    public bool DressedLeft_arm = false;
    public bool DressedRight_arm = false;

    public void CreateInventory(int count) 
    {
        int h = 0;
        int w = 0;
        for (int i = 0; i < count; i++)
        {
            if (UIInventory.GetComponent<Transform>().childCount < count)
            {
                w += 1;
                if (w > 4)
                {
                    h += 1;
                    w -= 4;
                }
                Cell.name = "Cell[" + h + "][" + w + "]";
                Instantiate(Cell, new Vector3(100f * w + Screen.width / 3, -100f * h + Screen.height / 1.5f, 0), Quaternion.identity, UIInventory.GetComponent<Transform>());
                
            }
        }

    }

    public void DeleteInventory() 
    {
        foreach (Transform child in UIInventory.GetComponent<Transform>())
        {
            Debug.Log(child);
            DestroyImmediate(child.gameObject);  
        }
    }

    private void CheckDressPerson() // Active gameObject cloth or not
    {
        for (int i = 0; i <= 4; i++)
        {
            switch (i)
            {
                case 0:
                    personClothesCanBeOnPerson[0].SetActive(DressedCloth_up);
                    break;
                case 1:
                    personClothesCanBeOnPerson[1].SetActive(DressedCloth_down);
                    break;
                case 2:
                    personClothesCanBeOnPerson[2].SetActive(DressedHelmet);
                    break;
                case 3:
                    personClothesCanBeOnPerson[3].SetActive(DressedLeft_arm);
                    break;
                case 4:
                    personClothesCanBeOnPerson[4].SetActive(DressedRight_arm);
                    break;
            }
        }
    }

    private void GetDressPerson()
    {

        /*
          *personPrefabsClothes*                *personClothes*
        Element 0 - PrefabsCloth_up,         Element 0 - Cloth_up,     
        Element 1 - PrefabsCloth_down,       Element 1 - Cloth_down,
        Element 2 - PrefabsCloth_helmet,     Element 2 - Cloth_helmet,
        Element 3 - PrefabsLeft_arm,         Element 3 - Left_arm,
        Element 4 - PrefabsRight_arm,        Element 4 - Right_arm,
        Element 5 - PrefabsBag               Element 5 - Bag
        */

        // To do some future *WHAT IN OBJECT WHERE*
        //Instantiate(personPrefabsClothesOnPerson[0], personClothesCanBeOnPerson[0].GetComponent<Transform>());
    }

    public void SetDressPerson(int element, bool dressed)
    {
        if (element >= 4)
        {
            element = 4;
        }
        if (element <= 0)
        {
            element = 0;
        }
        switch (element)
        {
            case 0:
                DressedCloth_up = dressed;
                break;
            case 1:
                DressedCloth_down = dressed;
                break;
            case 2:
                DressedHelmet = dressed;
                break;
            case 3:
                DressedLeft_arm = dressed;
                break;
            case 4:
                DressedRight_arm = dressed;
                break;
        }
    }


    public void SetActivityIneventory(int count)
    {
        if (UIInventory.activeSelf)
        {
            CreateInventory(count);
        }
        else
        {
            DeleteInventory();
        }
    }
}
