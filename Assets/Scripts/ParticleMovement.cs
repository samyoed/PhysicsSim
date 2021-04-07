using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    public float partSpeed = 1;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(8,8);
        rb = GetComponent<Rigidbody>();

        Vector3 direction = Random.insideUnitCircle.normalized;
        rb.AddForce(direction * partSpeed, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        rb.velocity = partSpeed * (rb.velocity.normalized);
    }

}
