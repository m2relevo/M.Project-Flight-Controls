using UnityEngine;
using System.Collections;

public class MovementFlight : MonoBehaviour
{
    //References
    public Rigidbody rb;

    //States
    private bool StateController = false;
    private bool Safety_FlightPropulsion = false;

    //Speed Values
    private float Overall_Speed;

    public float Speed_Accelerate_Max;
    public float Speed_Accelerate_Current;

    public float Speed_Decellerate_Max;
    public float Speed_Decellerate_Current;

    public float Speed_Pitch_Max;
    public float Speed_Pitch_Current;

    public float Speed_Roll_Max;
    public float Speed_Roll_Current;

    public float Speed_Yaw_Max;
    public float Speed_Yaw_Current;

    public float Speed_T_Lateral_Max;
    public float Speed_T_Lateral_Current;

    public float Speed_T_Vertecal_Max;
    public float Speed_T_Verecal_Current;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (Input.GetJoystickNames().Length < 1)
        {
            StateController = false;
        }

        if (Input.GetJoystickNames().Length > 0)
        {
            StateController = true;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            Debug.Log("Test Fire");
        }

        Accelerate();
        Decellerate();
        Pitch();
        Roll();
        Yaw();
        T_Lateral();
        T_Vertical();
    }

    void FixedUpdate()
    {
        Overall_Speed = Speed_Accelerate_Current + Speed_Decellerate_Current;

        rb.AddForce(transform.forward * (Overall_Speed) * Time.deltaTime);
        rb.AddTorque(Speed_Pitch_Current * Time.deltaTime, 0f, 0f, ForceMode.Impulse);

        if (Input.GetAxis("Pitch") == 0 && Speed_Pitch_Current > 0)
        {
            rb.AddTorque(0f, Speed_Pitch_Current - (Speed_Pitch_Current * 1), 0f, ForceMode.Impulse);
            Speed_Pitch_Current = 0;
        }

        if (Input.GetAxis("Pitch") == 0 && Speed_Pitch_Current < 0)
        {
            rb.AddTorque(0f, Speed_Pitch_Current + (Speed_Pitch_Current * 1), 0f, ForceMode.Impulse);
            Speed_Pitch_Current = 0;
        }
    }

    void Accelerate()
    {
        if (StateController == false)
        {
            if (Input.GetAxis("Accelerate") > 0 && Speed_Accelerate_Current < Speed_Accelerate_Max)
            {
                Speed_Accelerate_Current = Speed_Accelerate_Current + (2 + Time.deltaTime);

                if (Speed_Decellerate_Current < 0)
                {
                    Speed_Decellerate_Current = Speed_Decellerate_Current + (2 + Time.deltaTime);
                }
            }
        }

        else

        {

        }
    }

    void Decellerate()
    {
        if (StateController == false)
        {
            if (Input.GetAxis("Deccelerate") > 0 && Speed_Decellerate_Current > Speed_Decellerate_Max)
            {
                Speed_Decellerate_Current = Speed_Decellerate_Current - (2 - Time.deltaTime);

                if (Speed_Accelerate_Current > 0)
                {
                    Speed_Accelerate_Current = Speed_Accelerate_Current - (1 - Time.deltaTime);
                }
            }
        }

        else

        {

        }
    }

    void Pitch()
    {
        if (StateController == false)
        {
            if (Input.GetAxis("Pitch") > 0 && Speed_Pitch_Current < Speed_Pitch_Max)
            {
                Speed_Pitch_Current = Speed_Pitch_Current + (Input.GetAxis("Pitch") + Time.deltaTime);
            }

            if (Input.GetAxis("Pitch") < 0 && Speed_Pitch_Current > ((Speed_Pitch_Max-Speed_Pitch_Max)-Speed_Pitch_Max))
            {
                Speed_Pitch_Current = Speed_Pitch_Current + (Input.GetAxis("Pitch") + Time.deltaTime);
            }
        }

        else

        { }
    }

    void Roll()
    {
        if (StateController == false)
        {

        }

        else

        { }
    }

    void Yaw()
    {
        if (StateController == false)
        {

        }

        else

        { }
    }

    void T_Lateral()
    {
        if (StateController == false)
        {

        }

        else

        { }
    }

    void T_Vertical()
    {
        if (StateController == false)
        {

        }

        else

        { }
    }
}