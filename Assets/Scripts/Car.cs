using UnityEngine;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGainperSecond = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    // Start is called before the first frame update
    private int steerValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += speedGainperSecond * Time.deltaTime;
        transform.Rotate(0f, steerValue * turnSpeed * Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Steer(int value)
    {
        steerValue = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if(other.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
