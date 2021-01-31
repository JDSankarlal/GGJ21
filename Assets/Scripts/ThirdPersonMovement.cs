using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        //Getting some input to move
        if (dir.magnitude >= 0.1f)
        {
            //Angle to look at
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            //Smooths the rotation
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //Direction we want to move in
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (hit.transform.tag == "Door")
        {
            if (scene.name == "Level 1")
            {
                Debug.Log("COLLIDE");
                SceneManager.LoadScene("Level 2");
            }
            if (scene.name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            if (scene.name == "Level 3")
            {
                SceneManager.LoadScene("Level 4");
            }
            if (scene.name == "Level 4")
            {
                SceneManager.LoadScene("Level 5");
            }
            if (scene.name == "Level 5")
            {
                SceneManager.LoadScene("Level 6");
            }
            if (scene.name == "Level 6")
            {
                SceneManager.LoadScene("Level 7");
            }
        }
    }
}
