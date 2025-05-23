using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; //총알 프리펩
    public Transform firePos;// 발사 위치

    public float timer;
    public float cooldownTime;
    
    void Start() //1번 실행->무엇인가를 셋팅하는과정
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update() //무엇인가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);

        //생성하다 (생성대상, 생성위치, 회전상태)

        timer += Time.deltaTime; // 타이머기능
        if (timer>=cooldownTime) //현재 타이머가 쿨다운 시간보다 커졌다면
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        }
    }
}
