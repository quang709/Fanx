using System;
using System.Collections.Generic;
using System.Text;

namespace Fan
{
    class Fan
    {
        const int SLOW = 1;
        const int MEDIUM = 2;
        const int FAST = 3;
        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";
        public Fan() { }
        public int getSpeed()
        {
            return speed;
        }
        public void setSpeed(int newSpeed)
        {
            speed = newSpeed;
        }
        public bool isOn()
        {
            return on;
        }
        public void turnOn()
        {
            on = true;
        }
        public void turnOff()
        {
            on = false;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string newColor)
        {
            color = newColor;
        }
        public string toString()
        {
            string Text = $"Speed: {speed}\nColor: {color}\nRadius: {radius}\n";
            if (isOn())
            {
                Text += "Fan is on";
            }
            else Text += "Fan is off";
            return Text;
        }
    }
}