﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("has ganado");
        if (collision.gameObject.tag=="player")
        {
            SceneManager.LoadScene("Win");
        }


    }



}
