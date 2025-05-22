using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed=5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()   
    {
        ////this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        ////transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.W)) //앞으로 가는 기능
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))  //뒤으로 가는 기능
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))  //왼쪽으로 가는 기능
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))  //오른쪽으로 가는 기능
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h,0,v);
        Debug.Log($"현재 입력 : {dir}");
        transform.position += dir * moveSpeed * Time.deltaTime;


    }
}
