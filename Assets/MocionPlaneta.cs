using UnityEngine;

public class MocionPlaneta : MonoBehaviour
{

    public float rotationSpeed = 50f; // Velocidad de rotación en grados por segundo
    public float orbitSpeed = 10f; // Velocidad de órbita en grados por segundo
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); // Rotación del planeta sobre su propio eje
    }
}
