﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   
    void Update()
    {

        if (Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
