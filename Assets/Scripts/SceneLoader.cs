using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    
    //void hace que no devuelva nada la funcion 
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
