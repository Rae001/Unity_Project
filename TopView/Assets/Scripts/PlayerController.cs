using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void LookAt(Vector3 lookPoint)
    {
        Vector3 heightCorrectedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z) ;
        transform.LookAt(heightCorrectedPoint);
    }
     
    public void FixedUpdate()
    {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
        // fixedDeltaTime은 두 FixedUpdate 메소드가 호출된 시간 간격을 뜻함
    }
    // FixedUpdate를 사용하는 이유, 이부분은 정기적이고 짧게 반복적으로 실행할 때 사용, 그래야 다은 오브젝트 밑으로 끼어 들어가지 않는다.
    // FixedUpdate를 쓰면 프레임 저하가 발생해도 프레임에 시간의 가중치를 곱해 실행되어 이동속도를 유지한다.
}
