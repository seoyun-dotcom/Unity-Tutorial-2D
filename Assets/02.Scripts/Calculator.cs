using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        int addResult = AddMethod();

        int minusResult = MinusMethod();

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}");
    }

    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        //지역 변수 result
        int result = number1 - number2;

        return result;
    }
}
