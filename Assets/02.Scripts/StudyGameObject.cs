using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    //public GameObject destroyObj;

    //public Vector3 pos;
    //public Quaternion rot;
   
    void Start()
    {
        Debug.Log("생성되었습니다.");
        CreateAmongus();

        /*Destroy(destroyObj, 3f);*///3초뒤에 매개변수로 들어간 게임오브젝트를 파괴하는 기능
    }

    // void OnDestroy()
    //{
    //    Debug.Log("파괴되었습니다.");
    //}

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);//게임오브젝트를 생성하는 기능
        obj.name = "어몽어스 캐릭터";

        Debug.Log($"캐릭터의 자식 오브젝트의 수: {obj.transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름: {obj.transform.GetChild(0)}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름: {obj.transform.GetChild(obj.transform.childCount - 1)}");


    }
}
