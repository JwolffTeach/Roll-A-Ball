using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    public float lengthmodifier = 1.5f;
    public float lifeTime = 0.1f;

    private ParticleSystem ps;

    void Start() {
        offset = transform.position - player.transform.position;
        ps = gameObject.GetComponent<ParticleSystem>();
        //var ma = ps.main;
    }

    void LateUpdate() {
        transform.position = player.transform.position + offset;
        transform.rotation = player.transform.rotation;
    }

    public void Upgrade() {
        var ma = ps.main;
        lifeTime = lifeTime + lengthmodifier;
        ma.startLifetime = lifeTime;
        Debug.Log(lifeTime);
    }

}
