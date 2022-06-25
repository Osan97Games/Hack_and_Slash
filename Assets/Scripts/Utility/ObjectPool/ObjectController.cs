using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    //Inspect parameter
    [SerializeField] protected GameObject prefab;

    protected void objectOn(GameObject gameObject) // ������Ʈ Ȱ��ȭ
    {
        gameObject.SetActive(true);
    }
    protected void objectOff(GameObject gameObject) // ������Ʈ ��Ȱ��ȭ
    {
        gameObject.SetActive(false);
    }

    protected GameObject objectInstantiate() // ������Ʈ ����
    {
        GameObject instantiateObject = Instantiate(prefab);
        instantiateObject.SetActive(false);

        return instantiateObject;
    }
    protected GameObject objectInstantiate(string name) // �̸� ������ �Բ� ������Ʈ ����
    {
        GameObject instantiateObject = objectInstantiate();
        instantiateObject.name = name;

        return instantiateObject;
    }
}
