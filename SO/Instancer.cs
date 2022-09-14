using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    
    public void CreateInstance(GameObject obj)
    {
        Instantiate(prefab);
    }

    public void CreatInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3DataList)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
   
    
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DataList[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3DataList.Count)
        {
            num = 0;
        }
    }
   
    public void CreateInstanceFromListRandom(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DataList.Count - 1);
        Instantiate(prefab, obj.vector3DataList[num].value, Quaternion.identity);
    }
}
