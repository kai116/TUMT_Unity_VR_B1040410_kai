using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttom : MonoBehaviour {

    public void ResetGG()
    {
        SceneManager.LoadScene(0);
    }
    public void EXITDD()
    {
        Application.Quit();
    }
}
