using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{

    public float speed = 90;

    void Start(){

        Destroy(gameObject, 7);

    }

    void Update(){

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
