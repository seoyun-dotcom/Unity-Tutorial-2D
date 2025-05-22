using UnityEngine;

public class StudyComponent : MonoBehaviour
//���������� Ŭ������ : ����Ƽ�� ������ ����� ����ִ� ��
{
    public GameObject obj;   //ť�� ���ӿ�����Ʈ�� �������� �ʹ�
    ////���������� Ÿ�� ������
    public Mesh msh;
    public Material mat;


    //public Transform objTf;

    //public string changeName;//����Ƽ���� ������ ���ڿ� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateCube();
        CreateCube("Hello World");
        //obj = new GameObject();
        //obj.name = "Cube";

        ////obj = GameObject.Find("Main Camera");
        //obj = GameObject.FindGameObjectWithTag("Player");

        //objTf = GameObject.FindGameObjectWithTag("Player").transform;

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);

        //objTf.gameObject.SetActive(false);

    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name);
        
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;


        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;


        obj.AddComponent<BoxCollider>();

    }

   
}
