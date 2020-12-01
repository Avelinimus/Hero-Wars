using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmets : MonoBehaviour
{
    public SpritesGeneratorConteiner SpriteConteiners;

    public static int Defense { get; set; }
    public static string Name { get; set; }

    public void Start()
    {
        Generator();
    }

    public void Generator()
    {
        // Init sprite for down clothes
        GetComponent<SpriteRenderer>().sprite = SpriteConteiners.SpritesList[Random.Range(0, SpriteConteiners.SpritesList.Count)];
    }
}
