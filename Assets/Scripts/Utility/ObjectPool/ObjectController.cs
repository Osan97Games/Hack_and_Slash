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
