using UnityEngine;

public class Apple : MonoBehaviour, IFood
{
    public void Eat()
    {
        Debug.Log("Eating the Apple.");
    }
}