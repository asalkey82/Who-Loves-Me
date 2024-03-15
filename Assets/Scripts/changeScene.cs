using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
   
    public string sceneToLoad; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hand"))
        {
            Debug.Log("Hand interaction detected, changing scene...");
            SceneManager.LoadScene(sceneToLoad); // Load the specified scene
        }
    }
}