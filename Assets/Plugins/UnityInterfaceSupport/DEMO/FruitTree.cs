using UnityEngine;

/// <summary>
/// This is a behavior which allows a type of fruit to be attached to it.
/// </summary>
public class FruitTree : MonoBehaviour
{
    [Tooltip("A field which only accepts behaviors that extend IFood.")]
    [SerializeField, InterfaceType(typeof(IFood))]
    private MonoBehaviour food;

    /// <summary>
    /// We still have to cast the MonoBehaviour back to an IFood manually,
	/// so this quick one-liner should make the process seemless.
    /// </summary>
    /// <value>The 'food' behavior casted to IFood.</value>
    public IFood Food { get { return food as IFood; } }

    void OnValidate()
    {
        Food?.Eat();
    }
}
