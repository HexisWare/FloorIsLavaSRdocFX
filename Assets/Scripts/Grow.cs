using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grow : MonoBehaviour
{
    public Vector3 scale = new Vector3(0.01f,0.01f,0.01f);
    

    // Start is called before the first frame update
    void Start()
    {

    }

    /// <summary>
    /// Calculates the age of a person on a certain date based on the supplied date of birth.  Takes account of leap years,
    /// using the convention that someone born on 29th February in a leap year is not legally one year older until 1st March
    /// of a non-leap year.
    /// </summary>
    /// <param name="dateOfBirth">Individual's date of birth.</param>
    /// <param name="date">Date at which to evaluate age at.</param>
    /// <returns>Age of the individual in years (as an integer).</returns>
    /// <remarks>This code is not guaranteed to be correct for non-UK locales, as some countries have skipped certain dates
    /// within living memory.</remarks>
    // Update is called once per frame
    void Update()
    {
        // private Vector3 object = transform.localScale;
        transform.localScale += scale;
    }
}
