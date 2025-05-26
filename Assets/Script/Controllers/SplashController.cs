using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    [Header("������ ��'����")]
    [SerializeField] private GameObject splashPanel;
    [SerializeField] private CanvasGroup logoCanvasGroup; // CanvasGroup �� �������

    [Header("��������� ������")]
    [SerializeField] private float delayBeforeLogo = 1f;        // �������� ����� ������
    [SerializeField] private float fadeDuration = 2f;           // ��������� �������� ��������
    [SerializeField] private float logoVisibleDuration = 2f;    // ��� �������� ��������
    [SerializeField] private float delayAfterLogo = 1f;         // �������� ���� ���������

    private void Start()
    {
        StartCoroutine(PlaySplashSequence());
    }

    private IEnumerator PlaySplashSequence()
    {
        if (logoCanvasGroup == null || splashPanel == null)
        {
            Debug.LogError("�� ������� splashPanel ��� logoCanvasGroup � ���������.");
            yield break;
        }

        // �� ������� ������� ������� ��������
        logoCanvasGroup.alpha = 0f;

        // ������ ����� ������ ��������
        yield return new WaitForSeconds(delayBeforeLogo);

        // ������ ����� ��������
        yield return StartCoroutine(FadeCanvasGroup(logoCanvasGroup, 0f, 1f, fadeDuration));

        // ������� ������� �������
        yield return new WaitForSeconds(logoVisibleDuration);

        // ������ ��������� ��������
        yield return StartCoroutine(FadeCanvasGroup(logoCanvasGroup, 1f, 0f, fadeDuration));

        // �������� ����� ���������� �����
        yield return new WaitForSeconds(delayAfterLogo);

        // �������� splash panel
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
