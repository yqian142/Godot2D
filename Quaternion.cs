using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/* 
Homework Problems

Given that we have a 3D cube in your Unity scene, we want to 
animate our cube to rotate with Quaternions. 

*/ 
public class Quaternion : MonoBehaviour
{
    // TODO: Problem 1: Define Vector3 and Rotation variables here.
    public Vector3 result;
    public float rotation;
    // TODO: Problem 2: Define two Quaternions
    public Quaternion quaternion1;
    public Quaternion quaternion2;
    // Update is called once per frame
    void Update()
    {
        // Example Problem: Multiply a quaternion by a vector using Quaternion.Euler and save it as a temporary variable
        result = Quaternion.Euler(0, rotation, 0) * result;

        // TODO: Problem 3: Multiply a Quaternion by another Quaternion using Quaternion.Euler and save it as a temporary variable
        quaternion1 = Quaternion.Euler(0, rotation, 0);
        quaternion2 = quaternion1 * quaternion2;

        // TODO: Problem 4: Check if two quaternions are equal to each other. 
        // If they are, print out the "[Names of Quaternions] are Equal".
        // Else, print out "Quaternions are different"
        if (Quaternion.Equals(quaternion2, result))
        {
            Debug.log("quaternion2 and result are Equal");
        }
        else
        {
            Debug.log("Quaternions are different")
        }
        // TODO: Problem 5: Using Quaternion.Lerp, rotate your vector
        // The vector starts at (0,0,0) and wants to be rotated to (100, 100, 100)
        float speed = 0.01f;
        float timeCount = 0.0f;
        Vector3 startVector = new Vector3(0, 0, 0);
        Vector3 endVector = new Vector3(100, 100, 100);
        moveDirection = Quaternion.Lerp(startVector, endVector, speed * timeCount);
        timeCount = timeCount * Time.deltaTime;
    }
}
