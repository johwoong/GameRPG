using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �������� ���� ����
// ���� ��ȯ, ����Ʈ ����, �̺�Ʈ ó�� ���� ���

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

}
