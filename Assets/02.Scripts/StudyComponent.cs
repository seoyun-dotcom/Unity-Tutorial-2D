using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;   //ť�� ���ӿ�����Ʈ�� �������� �ʹ�

    public string changeName;//����Ƽ���� ������ ���ڿ� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }

   
}
