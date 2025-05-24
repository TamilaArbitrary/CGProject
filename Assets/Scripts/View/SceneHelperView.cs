using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneHelperView
{
    public static void LoadScene(string s, bool additive = false, bool setActive = false)
    {
        if (s == null)
        {
            s = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        }
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            s, additive ? UnityEngine.SceneManagement.LoadSceneMode.Additive : 0);

        if (setActive)
        {
            CallAfterDelayController.Create(0, () => {
                UnityEngine.SceneManagement.SceneManager.SetActiveScene(
                    UnityEngine.SceneManagement.SceneManager.GetSceneByName(s));
            });
        }
    }

    public static void UnloadScene(string s)
    {
        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(s);
    }
}