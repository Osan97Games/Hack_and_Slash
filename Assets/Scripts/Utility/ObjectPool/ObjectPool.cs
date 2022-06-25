using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : ObjectController
{
    //Inspect parameter
    [SerializeField] protected int objectCount;

    //Object pool List
    List<GameObject> objectPoolList;

    protected virtual void objectInitialize() // 초기 오브젝트 생성
    {
        objectPoolList = new List<GameObject>();
        for(int i = 0; i < objectCount; i++)
        {
            objectPoolList.Add(objectInstantiate());
        }
        Debug.Log("Generated " + objectPoolList.Count + " objects");
    }

    protected virtual void objectReturn(GameObject objectPointer) // 오브젝트 풀로 복귀
    {
        objectOff(objectPointer);
        objectPoolList.Add(objectPointer);
    }

    protected virtual GameObject objectPop() // 사용 오브젝트 Pop
    {
        if (objectPoolList.Count > 0)
        {
            int pointerIndex = objectPoolList.Count - 1;
            GameObject objectPointer = objectPoolList[pointerIndex];
            objectPoolList.RemoveAt(pointerIndex);
            return objectPointer;
        } 
        else
        {
            return objectInstantiate();
        }
    }
}
