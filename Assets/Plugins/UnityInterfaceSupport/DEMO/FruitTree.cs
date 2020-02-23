using UnityEngine;

public class FruitTree : MonoBehaviour
{
	[Tooltip("A field which only accepts behaviors that extend IFood.")]
	[InterfaceType(typeof(IFood))]
	public MonoBehaviour food;
}