using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
   public Vector3 value;

   public void UpdateValue(Transform obj)
   {
      value = obj.position;
   }

   public void UpdateTransform(Transform obj)
   {
      obj.localPosition = value;
   }
}
