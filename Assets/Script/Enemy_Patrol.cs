using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Patrol : MonoBehaviour
{
    // Start is called before the first frame update
    Helper_Script helper;
    public float speed = 1f;
    public float distance = 1f;

    private bool movingRight = true;

    public Transform groundDetection;

    void Start()
    {
        helper = gameObject.AddComponent<Helper_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        helper.Patrol();
    }
}
