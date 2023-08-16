using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryBirdLine : MonoBehaviour
{
    public Transform Bird;
    public LineRenderer line;
    
    private void Start()
    {
       
        line.positionCount = 2;
        line.SetPosition(0, Bird.position);
        line.SetPosition(1, Bird.position);
    }
    public void SetPOsition(int v, Vector3 position)
    {
        line.SetPosition(v,position);
    }
}
