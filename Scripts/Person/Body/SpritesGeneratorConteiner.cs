using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GeneratorConteiner", menuName = "ScriptableObjects/SpritesGenerator", order = 1)]

public class SpritesGeneratorConteiner : ScriptableObject
{
    public List<Sprite> SpritesList = new List<Sprite>();
}
