using UnityEngine;

public class Item : MonoBehaviour
{
    public bool interactedWith;

    public void InteractItem()
    {
        if (!interactedWith)
        {
            interactedWith = true;
            Debug.Log("Item interacted with");
                
        }
    }
}
