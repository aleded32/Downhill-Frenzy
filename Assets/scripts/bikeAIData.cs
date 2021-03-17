using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class bikeAIData {

    public float[] positionX;
    public float[] positionY;
    public float[] positionZ;

    public float[] rotationX;
    public float[] rotationY;
    public float[] rotationZ;


    public bikeAIData(bikeAIController AIController) 
    {

        positionX = new float[AIController.positions.Count];
        positionY = new float[AIController.positions.Count];
        positionZ = new float[AIController.positions.Count];

        rotationX = new float[AIController.rotations.Count];
        rotationY = new float[AIController.rotations.Count];
        rotationZ = new float[AIController.rotations.Count];

        for (int i = 0; i < AIController.positions.Count; i++)
        {
            positionX[i] = AIController.positions[i].x;
            positionY[i] = AIController.positions[i].y;
            positionZ[i] = AIController.positions[i].z;
        }

        for (int i = 0; i < AIController.rotations.Count; i++)
        {
            rotationX[i] = AIController.rotations[i].x;
            rotationY[i] = AIController.rotations[i].y;
            rotationZ[i] = AIController.rotations[i].z;
        }

    }
}
