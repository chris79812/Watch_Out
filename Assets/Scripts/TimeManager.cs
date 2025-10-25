using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
public class TimeManager : MonoBehaviour
{
    private int minutes;
        public int Minutes
    { get { return minutes; } set { minutes = value; OnMinutesChange(value); } }
    private int hours;
    private int Hours
    { get { return hours; } set { hours = value; OnHoursChange(value); } }
    private int days;
    private int Days
    { get { return days; } set { days = value; } }
    private float tempSeconds;

    public void Update()
    {
        tempSeconds += Time.deltaTime;
        if (tempSeconds > +1)
        {
            minutes += 1;
            tempSeconds = 0;

        }
    }

    private void OnMinutesChange(int value)
    {
        throw new NotImplementedException();
    }
    private void OnHoursChange(int value)
    {
        throw new NotImplementedException();
    }

    // 2:15
}
