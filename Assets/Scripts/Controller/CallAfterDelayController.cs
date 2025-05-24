using UnityEngine;
using System.Collections;

public class CallAfterDelayController : MonoBehaviour
{
    float delay;
    System.Action action;

    // ͳ���� �� ���� ��������� � ����� ����, ����� � ���������� 
    public static CallAfterDelayController Create(float delay, System.Action action)
    {
        CallAfterDelayController cad = new GameObject("CallAfterDelay").AddComponent<CallAfterDelayController>();
        cad.delay = delay;
        cad.action = action;
        return cad;
    }

    float age;

    void Update()
    {
        if (age > delay)
        {
            action();
            Destroy(gameObject);
        }
    }
    void LateUpdate()
    {
        age += Time.deltaTime;
    }
}