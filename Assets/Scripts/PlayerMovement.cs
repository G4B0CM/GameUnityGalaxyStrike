using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 10f;
    Vector2 movement;
    [SerializeField] float xClampedRange = 20f;
    [SerializeField] float yClampedRange = 20f;
    [SerializeField] float controllRollFactor = 1f;
    [SerializeField] float rotationSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        Quaternion targetRotationX = Quaternion.Euler(0f, 0f, -controllRollFactor * movement.x);
        Quaternion targetRotationY = Quaternion.Euler(0f, 0f, -controllRollFactor * movement.y);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotationY, rotationSpeed * Time.deltaTime);
        transform.localRotation = Quaternion.Lerp(transform.localRotation,targetRotationX,rotationSpeed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampedRange, xClampedRange);


        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampedRange, yClampedRange);
        transform.localPosition = new Vector3(clampedXPos, clampedYPos, 0f);
    }
}
