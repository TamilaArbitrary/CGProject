using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    [Header("Основні об'єкти")]
    [SerializeField] private GameObject splashPanel;
    [SerializeField] private CanvasGroup logoCanvasGroup; // CanvasGroup на логотипі

    [Header("Тривалість ефектів")]
    [SerializeField] private float delayBeforeLogo = 1f;        // Затримка перед появою
    [SerializeField] private float fadeDuration = 2f;           // Тривалість плавного переходу
    [SerializeField] private float logoVisibleDuration = 2f;    // Час видимості логотипу
    [SerializeField] private float delayAfterLogo = 1f;         // Затримка після зникнення

    private void Start()
    {
        StartCoroutine(PlaySplashSequence());
    }

    private IEnumerator PlaySplashSequence()
    {
        if (logoCanvasGroup == null || splashPanel == null)
        {
            Debug.LogError("Не вказано splashPanel або logoCanvasGroup у інспекторі.");
            yield break;
        }

        // На початку логотип повністю прозорий
        logoCanvasGroup.alpha = 0f;

        // Чекаємо перед появою логотипу
        yield return new WaitForSeconds(delayBeforeLogo);

        // Плавна поява логотипу
        yield return StartCoroutine(FadeCanvasGroup(logoCanvasGroup, 0f, 1f, fadeDuration));

        // Тримати логотип видимим
        yield return new WaitForSeconds(logoVisibleDuration);

        // Плавне зникнення логотипу
        yield return StartCoroutine(FadeCanvasGroup(logoCanvasGroup, 1f, 0f, fadeDuration));

        // Затримка перед зникненням панелі
        yield return new WaitForSeconds(delayAfterLogo);

        // Вимкнути splash panel
        splashPanel.SetActive(false);
    }

    private IEnumerator FadeCanvasGroup(CanvasGroup canvasGroup, float startAlpha, float endAlpha, float duration)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float alpha = Mathf.Lerp(startAlpha, endAlpha, elapsed / duration);
            canvasGroup.alpha = alpha;
            elapsed += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = endAlpha;
    }
}
