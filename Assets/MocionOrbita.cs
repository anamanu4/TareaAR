using UnityEngine;

public class MocionOrbita : MonoBehaviour
{
    public float orbitSpeed = 10f; // Velocidad de órbita en grados por segundo
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, orbitSpeed * Time.deltaTime); // Movimiento de órbita alrededor del sol
    }
}
