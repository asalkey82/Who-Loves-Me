using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
   
    public string sceneToLoad; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Debug.Log("Hand interaction detected, changing scene...");
            SceneManager.LoadScene(sceneToLoad); // Load the specified scene
        }
    }
}