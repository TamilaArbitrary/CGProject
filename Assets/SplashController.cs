using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour
{
    [SerializeField] private GameObject splashPanel;

    private void Start()
    {
        // Запускаємо корутину заставки
        StartCoroutine(HideSplashAfterDelay(3f));
    }

    private IEnumerator HideSplashAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        splashPanel.SetActive(false);
    }
}
