/*
 * 개발자 : 김선호
 * 생성일자 : 2022/07/02
 * 클래스 설명 : 플레이어와 적대하는 Object의 pool 생성을 위한 클래스, ObjectPool 상속 
 * 포함 기능
 *  - 해당 컴포넌트 생성 시 objectInitialize 실행
 *  - Object Pooling 테스트를 위한 메소드
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolEnemy : ObjectPool
{
    //Test List
    List<GameObject> testList = new List<GameObject>();
    void Start()
    {
        objectInitialize();
    }

    public void testObjectReturn() // Object Pool 복귀 테스트
    {
        GameObject testObjectPointer = testList[testList.Count - 1];
        objectReturn(testObjectPointer);
        testList.RemoveAt(testList.Count - 1); 
    }

    public void testObjectPop() // Object Pool 활성화 테스트
    {
        GameObject testObjectPointer = objectPop();
        testObjectPointer.SetActive(true);
        testList.Add(testObjectPointer);
    }
}
