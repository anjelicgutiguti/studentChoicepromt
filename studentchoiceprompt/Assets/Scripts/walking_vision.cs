using UnityEngine;

public class walking_vision : MonoBehaviour
{
    public float speed = 5.0f;

    public float sensitivity = 2.0f;

    public Rigidbody rb;
    public BerryCollector bc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BerryCollector>();
        bc.berryCount = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("Vertical") * speed;
        float hori = Input.GetAxis("Horizontal") * speed;
        rb.linearVelocity = new Vector3(hori, 0, vert);

       Debug.Log(Input.mousePositionDelta);

       float storedY = transform.rotation.eulerAngles.y + Input.mousePositionDelta.x;
       float storedX = transform.rotation.eulerAngles.x + Input.mousePositionDelta.y;
       
    }
}
