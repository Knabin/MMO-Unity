using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;   // 유일성이 보장된다
    static Managers Instance { get { Init(); return s_instance; } }  // 유일한 매니저를 갖고 온다

    InputManager _input = new InputManager();
    ResourceManager _resource = new ResourceManager();
    public static InputManager Input {  get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if(s_instance == null)
        {
            // 초기화
            // 각각의 Managers가 선언되었다고 해도 이렇게 찾아서 사용한다면 원본(@Managers)의 Managers가 instance에 저장될 것임
            GameObject go = GameObject.Find("@Managers");

            // Scene에 GameObject인 @Managers가 없다면 새로 추가함
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            // 새로운 Scene이 로드될 때 삭제되지 않게끔
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
