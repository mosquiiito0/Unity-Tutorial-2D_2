using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f; //���� �ӵ�
    public float revolutionSpeed = 100f; //���� �ӵ�
    public bool isRevolution = false;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);          //�ڱ� �ڽ��� ȸ���ϴ� ���

        if (isRevolution == true)
        {
            //�����ϴ� ���
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);

        }

    }
}
