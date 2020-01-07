using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    public void SetGravitySettings(Vector2 gravityValue)
    {
        Physics2D.gravity = gravityValue;
    }
}
