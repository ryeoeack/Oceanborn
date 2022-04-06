using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    public float lifespan;
    void Start()
    {
        StartCoroutine("removeRoutine");
    }
    IEnumerator removeRoutine()
    {
        yield return new WaitForSeconds(lifespan);
        Destroy(gameObject);
    }
}
