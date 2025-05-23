using UnityEngine;

public class StudyGameobject : MonoBehaviour
{
    public GameObject prefab;
    //public Vector3 pos;
    //public Quaternion rot;
    //public GameObject destroyObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // GameObject obj = Instantiate(prefab, pos, rot);
        // obj.name = "À¸¸ù¹Ç";
        //Destroy(destroyObj, 3f);
        CreateAmong();
    }

    public void CreateAmong()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "¾î¸ù";
    }


    //public void CreateAmongus()
    //{
    //    Game
    //}
    // Update is called once per frame
    void Update()
    {

    }
}
