using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed = 1f;
    public GameObject particleEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
}

    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("player"))
        {
            Destroy(gameObject);

            Instantiate(particleEffect, transform.position, transform.rotation);
        }

    }

}
