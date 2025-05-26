using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AdditiveLoadingView : MonoBehaviour
{
    // ��� �������� � ��������
    [SerializeField] private float delaySeconds = 3f;

    void Start()
    {
        StartCoroutine(LoadSceneWithDelay());
    }

    private IEnumerator LoadSceneWithDelay()
    {
        // ������ �������� (����� ��������)
        yield return new WaitForSeconds(delaySeconds);

        // ����������� ��������� �����
        SceneHelperView.LoadScene("SideMenu", additive: true);

        // �������� ������� ����� �� ������ �� ��������
        Scene mainScene = SceneManager.GetSceneByName("Levels");
        if (mainScene.IsValid())
        {
            SceneManager.SetActiveScene(mainScene);
        }
        else
        {
            Debug.LogError("����� 'Levels' �� �������� ��� �������.");
        }
    }
}
