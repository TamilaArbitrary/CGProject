using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AdditiveLoadingView : MonoBehaviour
{
    // Час затримки в секундах
    [SerializeField] private float delaySeconds = 3f;

    void Start()
    {
        StartCoroutine(LoadSceneWithDelay());
    }

    private IEnumerator LoadSceneWithDelay()
    {
        // Чекаємо затримку (показ заставки)
        yield return new WaitForSeconds(delaySeconds);

        // Завантажуємо додаткову сцену
        SceneHelperView.LoadScene("SideMenu", additive: true);

        // Отримуємо головну сцену та робимо її активною
        Scene mainScene = SceneManager.GetSceneByName("Levels");
        if (mainScene.IsValid())
        {
            SceneManager.SetActiveScene(mainScene);
        }
        else
        {
            Debug.LogError("Сцена 'Levels' не знайдена або недійсна.");
        }
    }
}
