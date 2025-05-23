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
        ///�Է°��� ���� ��ӵ� �ý���
        ///�̵� -> WASD, ȭ��ǥŰ����
        ///����->Space
        ///�ѽ��-> ���콺 ���� 

        //�ε巴�� �����ϴ� ��
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �� �������� ��
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;
        //Vector3 normalDir = dir.normalized;
        //Debug.Log($"���� �Է�: {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + dir);
    }
}

