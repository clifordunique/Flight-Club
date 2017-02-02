﻿using UnityEngine;
using System.Collections;
using System;

public class PlayerInput : Controller {
    public float AxisAdjust = 0.15f;
    public int PlayerNumber = 1;

    public override float MoveVer { get {
            float ver = Input.GetAxis("Vertical" + PlayerNumber);
            return ver;
            
        }
    }
    public override float MoveHor { get {
            float hor = Input.GetAxis("Horizontal" + PlayerNumber);
            return hor;
        } }
    public override float LookVer
    {
        get
        {
            float ver = Input.GetAxis("LookV");
            float perAdj = ver / (1 - AxisAdjust);
            if (ver != 0) { ver += perAdj * AxisAdjust; }
            return ver;

        }
    }
    public override float LookHor
    {
        get
        {
            float hor = Input.GetAxis("LookH");
            float perAdj = hor / (1 - AxisAdjust);
            if (hor != 0) { hor += perAdj * AxisAdjust; }
            return hor;
        }
    }
    public override float Jump
    {
        get
        {
            float jump = Input.GetAxis("Jump" + PlayerNumber);
            return jump;
        }
    }
    public override float Dash
    {
        get
        {
            float dash = Input.GetAxis("Dash" + PlayerNumber);
            return dash;
        }
    }
    public override bool Stall
    {
        get
        {
            bool stall = Input.GetButton("Stall" + PlayerNumber);
            return stall;
        }
    }
}
