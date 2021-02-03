using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelEnd : MonoBehaviour
{
    public string Winner;
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(Winner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
