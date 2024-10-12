using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Der Spieler, dem die Kamera folgen soll
    public Vector3 offset;   // Der feste Abstand und die feste Höhe zur Kameraposition relativ zum Spieler

    void Start()
    {
        // Initialisiere den Offset mit der aktuellen Distanz zur Kamera, falls nicht gesetzt
        if (offset == Vector3.zero)
        {
            offset = transform.position - player.position;
        }
    }

    void LateUpdate()
    {
        // Setze die Kamera auf die Position des Spielers plus den festen Offset
        transform.position = player.position + offset;
    }
}