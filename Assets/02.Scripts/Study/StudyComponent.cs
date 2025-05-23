using JetBrains.Annotations;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    public Mesh msh;
    public Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //obj = GameObject.FindGameObjectWithTag("YEE");
      //  Debug.Log($"�̸� : {obj.name}");
       // Debug.Log(obj.tag);
        //Debug.Log(obj.transform.position);
        //Debug.Log(obj.transform.rotation);
        //Debug.Log(obj.transform.localScale);

        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

        obj = new GameObject("NEW");
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        obj.AddComponent<BoxCollider>();

    }


}

