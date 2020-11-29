using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Changes Scenes
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
