using UnityEngine;

public class ChangeCubeColor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && this.CompareTag("Friend"))
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (other.CompareTag("Friend") && this.CompareTag("Enemy"))
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}