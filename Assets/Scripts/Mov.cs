using UnityEngine;

public class Mov : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody playerRB;
    [SerializeField] float maxSpeed = 100;
    [SerializeField] float actualSpeed = 0;
    [SerializeField] float handle = 15;
    [SerializeField] float acceleration = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();


    }

    private void Movement()
    {
        float vert = Input.GetAxis("Vertical");
        float hori = Input.GetAxis("Horizontal");
        if (actualSpeed + acceleration < maxSpeed)
        {
            actualSpeed += acceleration;
        }
        else
        {
            actualSpeed = maxSpeed;
        }
        player.transform.Translate(0, 0, actualSpeed * Time.deltaTime * vert);

        player.transform.Rotate(0f, hori * 10 * Time.deltaTime * handle, 0F);
    }
}
