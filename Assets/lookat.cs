using System.Collections;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}