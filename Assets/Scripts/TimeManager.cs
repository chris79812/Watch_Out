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
        if (value >= 60)
        {
            Hours++;
            minutes = 0;
        }
        if (Hours >= 24)
        {
            Hours = 0;
            Days++;

        }

    }
    private void OnHoursChange(int value)
    {
        if (value == 6)
        {
        }
        if (value == 8)
        {
        }
        if (value == 15)
        {
        }
        if (value == 22)
        {
        }

    }

    
    private IEnumerable LerpSkyBox(Texture2D a, Texture2D b, float time)
    {
        RenderSettings.skybox.SetTexture("_Texture1", a);
        RenderSettings.skybox.SetTexture("_Texture2", b);

    }

    // WORK AT HOME
}
