using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;   //큐브 게임오브젝트를 가져오고 싶다

    public string changeName;//유니티에서 설정할 문자열 변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }

   
}
