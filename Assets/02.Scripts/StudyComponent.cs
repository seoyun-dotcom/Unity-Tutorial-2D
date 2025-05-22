using UnityEngine;

public class StudyComponent : MonoBehaviour
//접근제한자 클래스명 : 유니티의 유용한 기능이 들어있는 곳
{
    public GameObject obj;   //큐브 게임오브젝트를 가져오고 싶다
    ////접근제한자 타입 변수명
    public Mesh msh;
    public Material mat;


    //public Transform objTf;

    //public string changeName;//유니티에서 설정할 문자열 변수

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
