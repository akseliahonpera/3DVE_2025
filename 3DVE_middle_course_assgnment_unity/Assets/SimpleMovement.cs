using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject player; 
    public GameObject camera;
    private float speed = 10f;

    public float sensitivityX;
    public float sensitivityY;
    public float cameraDistance;
    public Transform orientation;

    float x_rotation;
    float y_rotation;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
	    transform.Translate(Vector3.forward * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.S)) {
	    transform.Translate(Vector3.back * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.A)) {
	    transform.Translate(Vector3.left * Time.deltaTime*speed);
        }
        if (Input.GetKey(KeyCode.D)) {
	    transform.Translate(Vector3.right * Time.deltaTime*speed);
        }

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime*sensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime*sensitivityY;

        x_rotation -= mouseY;
        y_rotation += mouseX;

        x_rotation = Mathf.Clamp(x_rotation,-90f,90f);

        transform.rotation = Quaternion.Euler( x_rotation,y_rotation,0);
       // orientation.rotation = Quaternion.Euler(0,y_rotation,0);


    }
}
