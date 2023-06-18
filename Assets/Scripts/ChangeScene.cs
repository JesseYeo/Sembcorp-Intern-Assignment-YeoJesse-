using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MainLevel(int sceneID)
    {
        //open scene index 1 = Airport
        SceneManager.LoadScene(sceneID);
        Debug.Log("changing game level");
    }

}
