using UnityEngine;

public class MoveMent : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5f;

    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    void Update()
    {
        ///Input System (Old - Legacy)
        ///입력값에 대한 약속된 시스템
        ///이동 -> WASD, 화살표키보드
        ///점프->Space
        ///총쏘기-> 마우스 왼쪽 

        //부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 딱 떨어지는 값
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;
        //Vector3 normalDir = dir.normalized;
        //Debug.Log($"현재 입력: {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + dir);
    }
}

