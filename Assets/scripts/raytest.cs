using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytest : MonoBehaviour
{
    public float distRay = 1f;
    private void Start()
    {

    }
    void Update()
    {

        Debug.DrawRay(transform.position, Vector3.forward*distRay , Color.green);
        Debug.DrawRay(transform.position, Vector3.right * distRay, Color.green);
        Debug.DrawRay(transform.position, Vector3.back * distRay, Color.green);
        Debug.DrawRay(transform.position, Vector3.left * distRay, Color.green);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.left, out hit, distRay))
        {
            if (hit.collider.tag == "enemyball")
            {
                if (hit.collider.gameObject.GetComponent<MeshRenderer>().material.color != Color.blue)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                    hit.collider.gameObject.GetComponentInParent<cube_enemy>().enemyball++;
                }
            }
        }
        else if (Physics.Raycast(transform.position, Vector3.back, out hit, distRay))
        {
            if (hit.collider.tag == "enemyball")
            {
                if (hit.collider.gameObject.GetComponent<MeshRenderer>().material.color != Color.blue)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                    hit.collider.gameObject.GetComponentInParent<cube_enemy>().enemyball++;

                }
            }
        }
        if (Physics.Raycast(transform.position, Vector3.right, out hit, distRay))
        {
            if (hit.collider.tag == "enemyball")
            {
                if (hit.collider.gameObject.GetComponent<MeshRenderer>().material.color != Color.blue)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                    hit.collider.gameObject.GetComponentInParent<cube_enemy>().enemyball++;
                }
            }
        }
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, distRay))
        {
            if (hit.collider.tag == "enemyball")
            {
                if (hit.collider.gameObject.GetComponent<MeshRenderer>().material.color != Color.blue)
                {
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                    hit.collider.gameObject.GetComponentInParent<cube_enemy>().enemyball++;
                }

            }
        }
    }
}