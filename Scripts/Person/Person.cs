using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    private static string[] genders = { "male", "female" };
    private static string[] male_names = { };
    private static string[] female_names = { };

    List<string> gendersRange = new List<string>(genders);


    public static string Info() 
    {
        return "";
    }
}
