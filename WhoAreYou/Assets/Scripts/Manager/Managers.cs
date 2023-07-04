using UnityEngine;

public class Managers : MonoBehaviour
{
    // 통합 매니저 인스턴스
    static Managers _managerInstance;
    static Managers ManagerInstance { get { Init(); return _managerInstance; } }

    // 갖가지 매니저들의 인스턴스
    static InputManager _input;
    static InputManager Input { get { return _input; } }

    void Awake()
    {
        Init();
    }

    void Update()
    {
        
    }

    static void Init()
    {
        if (_managerInstance == null)
        {
            GameObject go = GameObject.Find("@Manager");
            if (go == null)
            {
                go = new GameObject("@Manager");
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            _managerInstance = go.GetComponent<Managers>();
        }
    }
}
