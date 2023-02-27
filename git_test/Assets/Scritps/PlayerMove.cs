using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float speed = 10f;
    public float dash = 5f;
    public float rotSpeed = 3f;

    private Vector3 dir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        dir.Normalize();
        
    }



    private void FixedUpdate()
    {
        //if (dir != Vector3.zero)
        //{
        //    transform.forward = Vector3.Lerp(transform.forward, dir, rotSpeed * Time.deltaTime);
        //    // �÷��̾ ������ �̵��ϴٰ� �ٸ� �������� Ʋ������ �ڿ������� ȸ�� ����
        //}

        rigidbody.MovePosition(this.gameObject.transform.position + dir * speed * Time.deltaTime);
    }
}
