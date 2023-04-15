using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] Transform projectilePrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] LineRenderer lineRenderer;

    [SerializeField] private float launchForce = 1.5f;
    [SerializeField] private float trajectoryTimeStep = 0.05f;
    [SerializeField] private int trajectoryStepCount = 15;

    [SerializeField] private int remainingBall = 2;

    private Vector2 velocity, startMousePos, currentMousePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && remainingBall > 0)
        { 
            startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }//click left button
            
        if (Input.GetMouseButton(0) && remainingBall > 0) 
        {
            currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            velocity = (startMousePos - currentMousePos) * launchForce;
                     
            DrawTrajectory();
            RotateLauncher();
        }//Hold left button
            
        if (Input.GetMouseButtonUp(0) && remainingBall > 0)
        {
            FireProjectile();
            ClearTrajectory();
            remainingBall--;
        }//Release left button
            
    }

    void DrawTrajectory() 
    {
        Vector3[] position = new Vector3[trajectoryStepCount];
        for (int i = 0; i < trajectoryStepCount; i++)
        {
            float t = i * trajectoryTimeStep;
            Vector3 pos = (Vector2)spawnPoint.position + velocity * t + 0.5f * Physics2D.gravity* t* t;

            position[i] = pos;
        }

        lineRenderer.positionCount = trajectoryStepCount;
        lineRenderer.SetPositions(position);
    }//Draw guideline

    void RotateLauncher()
    {
        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }//Rotate Arm

    void FireProjectile()
    {
        Transform pr = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);

        pr.GetComponent<Rigidbody2D>().velocity = velocity;
    }//Throw the ball

    void ClearTrajectory()
    {
        lineRenderer.positionCount = 0;
    }//Remove guide line
}
