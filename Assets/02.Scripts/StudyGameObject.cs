using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    //public GameObject destroyObj;

    //public Vector3 pos;
    //public Quaternion rot;
   
    void Start()
    {
        Debug.Log("�����Ǿ����ϴ�.");
        CreateAmongus();

        /*Destroy(destroyObj, 3f);*///3�ʵڿ� �Ű������� �� ���ӿ�����Ʈ�� �ı��ϴ� ���
    }

    // void OnDestroy()
    //{
    //    Debug.Log("�ı��Ǿ����ϴ�.");
    //}

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);//���ӿ�����Ʈ�� �����ϴ� ���
        obj.name = "���� ĳ����";

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� ��: {obj.transform.childCount}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸�: {obj.transform.GetChild(0)}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸�: {obj.transform.GetChild(obj.transform.childCount - 1)}");


    }
}
