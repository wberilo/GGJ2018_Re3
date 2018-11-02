using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void LoadByIndex(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}