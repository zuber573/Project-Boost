using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This is Friendly");
                  break;
            case "Finish":
                Debug.Log("This is the Finish");
                break;
            case "Fuel":
                Debug.Log("Fuel");
                break;
                default:
                Debug.Log("sorry you blew tf up");
                break;

        }
    }
}