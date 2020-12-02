using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control : MonoBehaviour
{
    
    public static GameObject Target;
    public GameObject Camera;
    private Inventory Inventory = new Inventory();
    public bool CanTake;

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
                Inventory Inventory = Target.GetComponent<Inventory>();
                /* MOVEMENT INPUTS */
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
                /* INVENTORY */
                if (Input.GetKeyDown("e"))
                {
                    Inventory.UIInventory.SetActive(!Inventory.UIInventory.active);
                }
                Inventory.SetActivityIneventory(Target.GetComponent<Person>().INVENTORY_SIZE);
            }
        }
        else
        {
            // CAMERA INPUTS
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
