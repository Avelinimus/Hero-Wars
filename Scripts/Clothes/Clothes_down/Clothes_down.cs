using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes_down : MonoBehaviour
{
    // Conteiners for person clothes_down
    public SpritesGeneratorConteiner SpriteConteiners;

    public static int Defense { get; set; }  
    public static string Name { get; set; } 
    public static string Qualuty { get; set; }
    public static bool OnPerson { get; set; }


    public void Start()
    {
        Generator();
    }

    public void Update()
    {
        CheckLayerItem();// check layer
    }

    public void Generator()
    { 
        // Init sprite for down clothes
        GetComponent<SpriteRenderer>().sprite = SpriteConteiners.SpritesList[Random.Range(0, SpriteConteiners.SpritesList.Count)];
        OnPerson = false;
    }

    public void CheckLayerItem() 
    {  
        if (OnPerson) {
            GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        else 
        {
            GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }
}
