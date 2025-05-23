using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);

    }
    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
