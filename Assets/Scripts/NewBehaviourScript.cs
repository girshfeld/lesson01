using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField]
    private int _myField;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Log!");
        Debug.LogWarning("Log!!");
        Debug.LogError("Log!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
