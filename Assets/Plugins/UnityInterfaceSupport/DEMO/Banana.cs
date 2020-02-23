using UnityEngine;

public class Banana : MonoBehaviour, IFood
{
    public void Eat()
    {
        Debug.Log("Eating the Banana.");
    }
}