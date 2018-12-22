using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    int attempts1 = GameManager.attempts;
    public Rigidbody rb;
    public Text currentAttempt;

    public float forwardForce = 2000f;
    public float upwardForce = 0f;
    public float sideForce = 0f;


    // Start is called before the first frame update
    public void Start()
    {
        currentAttempt.text = $"Attempt {attempts1}";
    }

    void FixedUpdate()
    {
            rb.AddForce(sideForce, upwardForce, forwardForce * Time.deltaTime, ForceMode.Force);

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                sideForce = 100f;
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("Key D pressed, player moved right");
                sideForce = 0f;
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                sideForce = -100f;
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("Key A pressed, player moved left");
                sideForce = 0f;
            }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
