/*
 * 개발자 : 김선호
 * 생성일자 : 2022/07/02
 * 클래스 설명 : Unity에서 생성한 Object를 제어하기 위한 클래스
 * 포함 기능
 *  - 오브젝트 활성화
 *  - 오브젝트 비활성화
 *  - 오브젝트 생성
 *  - 이름 설정과 함께 오브젝트 생성
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    //Inspect parameter
    [SerializeField] protected GameObject prefab;

    protected void objectOn(GameObject gameObject) // 오브젝트 활성화
    {
        gameObject.SetActive(true);
    }
    protected void objectOff(GameObject gameObject) // 오브젝트 비활성화
    {
        gameObject.SetActive(false);
    }

    protected GameObject objectInstantiate() // 오브젝트 생성
    {
        GameObject instantiateObject = Instantiate(prefab);
        instantiateObject.SetActive(false);

        return instantiateObject;
    }
    protected GameObject objectInstantiate(string name) // 이름 설정과 함께 오브젝트 생성
    {
        GameObject instantiateObject = objectInstantiate();
        instantiateObject.name = name;

        return instantiateObject;
    }
}
