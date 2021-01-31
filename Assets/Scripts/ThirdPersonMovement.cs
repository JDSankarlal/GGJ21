using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float gravity = -9.81f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool hasKey;
    bool isGrounded;

    private FMOD.Studio.EventInstance doorInst;
    private FMOD.Studio.EventInstance endlvlInst;

    Scene scene;
    Vector3 velocity;
    // Update is called once per frame

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Level 1")
        {
            hasKey = true;
        }
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
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


        if (hit.transform.tag == "Key")
        {
            hasKey = true;
            Destroy(hit.gameObject);
        }

        if (hit.transform.tag == "Door" && hasKey)
        {
            if (scene.name == "Level 1")
            {
                Debug.Log("COLLIDE");
                endLevelSounds();
                SceneManager.LoadScene("Level 2");
                hasKey = false;
            }
            if (scene.name == "Level 2")
            {
                endLevelSounds();
                SceneManager.LoadScene("Level 3");
                hasKey = false;
            }
            if (scene.name == "Level 3")
            {
                endLevelSounds();
                SceneManager.LoadScene("Level 4");
                hasKey = false;
            }
            if (scene.name == "Level 4")
            {
                endLevelSounds();
                SceneManager.LoadScene("Level 5");
                hasKey = false;
            }
            if (scene.name == "Level 5")
            {
                endLevelSounds();
                SceneManager.LoadScene("Level 6");
                hasKey = false;
            }
            if (scene.name == "Level 6")
            {
                endLevelSounds();
                SceneManager.LoadScene("Level 7");
                hasKey = false;
            }
        }
    }

    void endLevelSounds()
    {
        doorInst = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/Door");
        doorInst.start();
        doorInst.release();

        endlvlInst = FMODUnity.RuntimeManager.CreateInstance("event:/SFX/Level Complete");
        endlvlInst.start();
        endlvlInst.release();
    }
}