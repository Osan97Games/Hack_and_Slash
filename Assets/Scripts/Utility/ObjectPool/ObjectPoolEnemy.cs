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

    public void testObjectReturn() // Object Pool ���� �׽�Ʈ
    {
        GameObject testObjectPointer = testList[testList.Count - 1];
        objectReturn(testObjectPointer);
        testList.RemoveAt(testList.Count - 1); 
    }

    public void testObjectPop() // Object Pool Ȱ��ȭ �׽�Ʈ
    {
        GameObject testObjectPointer = objectPop();
        testObjectPointer.SetActive(true);
        testList.Add(testObjectPointer);
    }
}
