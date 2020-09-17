using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 1) 나 혹은 상대한테 Rigidbody가 있어야 한다. (isKinematic : Off)
    // 2) 나한테 Collider가 있어야 한다. (isTrigger : Off)
    // 3) 상대한테 Collider가 있어야 한다. (isTrigger : Off)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name} !");
    }

    // 1) 둘 다 Collider가 있어야 한다.
    // 2) 둘 중 하나는 isTrigger : On
    // 3) 둘 중 하나는 Rigidbody가 있어야 한다.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger @ {other.gameObject.name} !");
    }

    void Start()
    {
        
    }

    void Update()
    {
        // 플레이어가 바라보고 있는 로컬 forward 계산
        /*
        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10.0f, Color.red);
        RaycastHit hit;

        if (Physics.Raycast(transform.position + Vector3.up, look, out hit, 10.0f))
        {
            Debug.Log($"Raycast {hit.collider.gameObject.name} !");
        }

        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10.0f);

        foreach(RaycastHit h in hits)
        {
            Debug.Log($"Raycast {h.collider.gameObject.name} !");
        }*/

        // Local <-> World <-> Viewport <-> Screen (화면)

        // Debug.Log(Input.mousePosition);     //Screen, 각 픽셀에 대응, 좌측 하단이 (0, 0)
        // Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));  // Viewport, 0~1 값을 가짐, 좌측 하단이 (0, 0), Screen과 매우 유사하나 비율에 대해 표시함

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
        //    }
        //}
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            // Monster인 경우에만 Raycast
            //int mask = ((1 << 8) | (1 << 9));

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, LayerMask.GetMask("Monster")))
            {
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
            }
        }
        */
    }
}
