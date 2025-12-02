using UnityEngine;
using UnityEngine.InputSystem;   // <-- needed for new input system

public class OrbShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;

    void Update()
    {
        // NEW INPUT SYSTEM — this always works in the John Lemon project
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }
}
