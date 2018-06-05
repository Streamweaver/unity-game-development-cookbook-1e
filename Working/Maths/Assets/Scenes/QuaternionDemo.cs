﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        {
            // BEGIN quaternions
            // Quaternions allow you to represent a rotation. All of Unity's
            // rotations are internally stored as quaternions.

            // The internals of Quaternions are based on complex numbers. For
            // our purposes, it doesn't matter too much how they work internally;
            // instead, it's enough to think of them as objects that represent 
            // 'rotations'.

            // Let's start by defining a rotation that rotates around 90 degrees
            // on the X axis. When we refer to creating a rotation by rotating
            // around the X, Y and Z axes, these angles are referred to as 
            // "Euler angles" (named after the mathmatician Leonhardt Euler,
            // whose name is pronounced "oiler", and not "yew-ler".)

            var rotation = Quaternion.Euler(90, 0, 0);

            // You can use this to rotate a point around the origin.
            var input = new Vector3(0, 0, 1);

            var result = rotation * input;
            // = (0, -1, 0)

            // The 'identity' quaternion is one that represents no rotation at
            // all.
            var identity = Quaternion.identity;

            // You can interpolate between two rotations using the Slerp method.
            // Slerp is short for "spherical linear interpolation", and is a way
            // to smoothly move between to rotations in a way that means that the
            // change in angle is constant at every step. This is better than
            // a linear interpolation of angles, in which the angles change at a 
            // non-constant rate.

            var rotationX = Quaternion.Euler(90, 0, 0);

            var halfwayRotated = Quaternion.Slerp(identity, rotationX, 0.5f);

            // Quaternions can be combined together. For example, to rotate
            // something around the Y axis and then around the X axis, you
            // multiply them (they're applied in reverse order):

            var combinedRotation = Quaternion.Euler(90, 0, 0) * // rotate around X
                                   Quaternion.Euler(0, 90, 0); // rotate around Y

            // Note that this combination is not "commutative" - the order of
            // multiplication matters.
            // END quaternions
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
