using UnityEngine;
public class EndTrigger : MonoBehaviour
{

     void OnTriggerEnter ()
    {
        Debug.Log("Calling Game Manager");
        GameManager.gameManager.CompleteLevel();
    }

}
