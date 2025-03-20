using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    [SerializeField] float magnusCoefficient = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
        }
        ApplyMagnusEffect();
    }

    void Kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = magnusCoefficient * Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce, ForceMode.Force);
    }
}