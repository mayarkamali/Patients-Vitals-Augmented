using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// The patient class is a scriptable object to be able to create multiple patient objects with their attributes

[CreateAssetMenu(fileName = "New_Patient", menuName = "ScriptableObjects/Patient", order = 0)]
public class Patient : ScriptableObject
{
    public string name;
    public int age;
    public float blood_pressure;
    public string description;
    public float oxygen_level;
    public string symptoms;
    


}
