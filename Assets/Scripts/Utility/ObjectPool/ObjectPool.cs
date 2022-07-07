/*
 * ������ : �輱ȣ
 * �������� : 2022/07/02
 * Ŭ���� ���� : Object Pooling ������ ���� Ŭ����, ObjectController ��� 
 * ���� ���
 *  - �ʱ� ������Ʈ ����
 *  - ������Ʈ Ǯ�� ����
 *  - ��� ������Ʈ Pop
 * 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : ObjectController
{
    //Inspect parameter
    [SerializeField] protected int objectCount;

    //Object pool List
    List<GameObject> objectPoolList;

    protected virtual void objectInitialize() // �ʱ� ������Ʈ ����
    {
        objectPoolList = new List<GameObject>();
        for(int i = 0; i < objectCount; i++)
        {
            objectPoolList.Add(objectInstantiate());
        }
        Debug.Log("Generated " + objectPoolList.Count + " objects");
    }

    protected virtual void objectReturn(GameObject objectPointer) // ������Ʈ Ǯ�� ����
    {
        objectOff(objectPointer);
        objectPoolList.Add(objectPointer);
    }

    protected virtual GameObject objectPop() // ��� ������Ʈ Pop
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
