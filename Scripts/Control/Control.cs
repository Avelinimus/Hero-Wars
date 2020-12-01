using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Control : MonoBehaviour
{
    
    public static GameObject Target;
    public GameObject Camera;

    void Update() 
    {
        Inputs(); //Control player
    }
    
    public void Inputs() 
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Target = null;
        }
        if (Target != null)
        {
            if (Target.GetComponent<Person>().CONTROL)
            {
                if (Input.GetKey("a"))
                {
                    Target.GetComponent<Person>().POSITION -= new Vector2(0.01f, 0).normalized * Time.deltaTime;
                }
                if (Input.GetKey("d"))
                {
                    Target.GetComponent<Person>().POSITION += new Vector2(0.01f, 0).normalized * Time.deltaTime;
                }
                if (Input.GetKey("w"))
                {
                    Target.GetComponent<Person>().POSITION += new Vector2(0, 0.01f).normalized * Time.deltaTime;
                }
                if (Input.GetKey("s"))
                {
                    Target.GetComponent<Person>().POSITION -= new Vector2(0, 0.01f).normalized * Time.deltaTime;
                }
                Camera.GetComponent<Transform>().position = new Vector3(Target.GetComponent<Person>().POSITION.x, Target.GetComponent<Person>().POSITION.y, -10);
            }
        }
        else
        {
            if (Input.GetKey("a"))
            {
                Camera.GetComponent<Transform>().position -= new Vector3(1f, 0).normalized * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                Camera.GetComponent<Transform>().position += new Vector3(1f, 0).normalized * Time.deltaTime;
            }
            if (Input.GetKey("w"))
            {
                Camera.GetComponent<Transform>().position += new Vector3(0, 1f).normalized * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                Camera.GetComponent<Transform>().position -= new Vector3(0, 1f).normalized * Time.deltaTime;
            }
        }
    }
    
}
