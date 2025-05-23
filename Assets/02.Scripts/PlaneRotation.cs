using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    public Transform targetPlanet;

    public float rotSpeed = 30f;
    public float revolutionSpeed = 100f;
    public bool isRevolution = false; // 논리 타입 -> true / false

    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true)
        {
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
    }
}
