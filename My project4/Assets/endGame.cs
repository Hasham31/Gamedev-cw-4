using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        SceneManager.LoadScene("level 1");
    }








}
