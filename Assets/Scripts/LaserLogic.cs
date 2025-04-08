using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LaserLogic : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform TargetPoint;
    [SerializeField] float targetDistance = 145f;

    bool isFiring = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ProcessFiring();
        MoveCrosshair();
        MoveTargetPoint();
        AimLasers();
    }

    private void MoveTargetPoint()
    {
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        TargetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }
    public void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
        
    }
    void MoveCrosshair()
    {
        crosshair.position = Input.mousePosition;
    }

    void AimLasers()
    {
        foreach (GameObject laser in lasers)
        {
            Vector3 fireDirection = TargetPoint.position - this.transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(fireDirection);
            laser.transform.rotation = rotationToTarget;
        }
    }
}
