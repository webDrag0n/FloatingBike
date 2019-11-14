﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Vector3 delta_pos;
    // Start is called before the first frame update
    void Start()
    {
        delta_pos = target.transform.position - transform.position;
    }

    private void FixedUpdate()
    {
        //相机的位置
        Vector3 targetPos = target.transform.position - Vector3.up * delta_pos.y * 0.5f - target.transform.forward * delta_pos.z;
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 5);
        //相机的角度
        transform.LookAt(target.transform.position + target.transform.forward * 5);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = target.transform.position - delta_pos;
        //transform.RotateAround(target.transform.position + new Vector3(0, 0, 1), target.transform.rotation.ToEuler(), 1);
        
    }
}
