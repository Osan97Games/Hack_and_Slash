/*
 * ������ : �輱ȣ
 * �������� : 2022/07/07
 * Ŭ���� ���� : Unity���� ������ Object�� �̵� ����� ���� Ŭ����
 * ���� ���
 *  - GameObject�� ��ġ �̵�
 * 
*/

using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    protected virtual void objectMove(GameObject targetObject, float moveSpeed, float x, float y, float z)
    {
        targetObject.transform.Translate(new Vector3(x, y, z) * moveSpeed * Time.deltaTime);
    }

    protected virtual void objectMove(GameObject targetObject, float moveSpeed, float x, float y)
    {
        targetObject.transform.Translate(new Vector3(x, y) * moveSpeed * Time.deltaTime);
    }

    protected virtual void objectMove(GameObject targetObject, float moveSpeed, Vector3 moveVector)
    {
        targetObject.transform.Translate(moveVector * moveSpeed * Time.deltaTime);
    }
}
