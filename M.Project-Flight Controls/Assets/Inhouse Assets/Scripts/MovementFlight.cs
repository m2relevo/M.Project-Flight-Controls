using UnityEngine;
using System.Collections;

public class MovementFlight : MonoBehaviour
{
    private bool StateController = false;
    private bool Safety_FlightPropulsion = false;

    //Speed Values
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
        transform.Translate(Vector3.forward * (Speed_Accelerate_Current-Speed_Decellerate_Current) * Time.deltaTime);

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

    void Accelerate()
    {
        

        if (StateController == false)
        {
            if (Input.GetAxis("Accelerate") > 0 && Speed_Accelerate_Current < Speed_Accelerate_Max)
            {
                Speed_Accelerate_Current = Speed_Accelerate_Current + (1 + Time.deltaTime);
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
            if (Input.GetAxis("Deccelerate") > 0 && Speed_Decellerate_Current < Speed_Decellerate_Max)
            {
                Speed_Decellerate_Current = Speed_Decellerate_Current + (1 + Time.deltaTime);
            }
        }

        else

        {

        }
    }

    void Pitch()
    {
        if (StateController == true)
        {

        }

        else

        { }
    }

    void Roll()
    {
        if (StateController == true)
        {

        }

        else

        { }
    }

    void Yaw()
    {
        if (StateController == true)
        {

        }

        else

        { }
    }

    void T_Lateral()
    {
        if (StateController == true)
        {

        }

        else

        { }
    }

    void T_Vertical()
    {
        if (StateController == true)
        {

        }

        else

        { }
    }
}