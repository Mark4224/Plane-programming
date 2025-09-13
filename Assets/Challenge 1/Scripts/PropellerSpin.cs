using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationspeed = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationspeed * Time.deltaTime);

    }
}.

