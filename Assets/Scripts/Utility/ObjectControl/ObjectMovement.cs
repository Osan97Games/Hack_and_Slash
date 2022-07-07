/*
 * 개발자 : 김선호
 * 생성일자 : 2022/07/07
 * 클래스 설명 : Unity에서 생성된 Object의 이동 기능을 위한 클래스
 * 포함 기능
 *  - GameObject의 위치 이동
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
