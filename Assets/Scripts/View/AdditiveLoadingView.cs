using UnityEngine;
using UnityEngine.SceneManagement;

public class AdditiveLoadingView : MonoBehaviour
{
    void Start()
    {
        SceneHelperView.LoadScene("SideMenu", additive: true);
        Scene mainScene = SceneManager.GetSceneByName("Levels");
        SceneManager.SetActiveScene(mainScene);
    }
}