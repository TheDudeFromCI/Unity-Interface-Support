using UnityEngine;
using System;

/// <summary>
/// When this attribute is attached to a MonoBehaviour field within a
/// Unity Object, this allows an interface to be specified in to to
/// entire only a specific type of MonoBehaviour can be attached.
/// </summary>
public class InterfaceTypeAttribute : PropertyAttribute
{
	public Type type;

	/// <summary>
	/// Creates a new InterfaceType attribute.
	/// </summary>
	/// <param name="type">The type of interface which is allowed.</param>
	public InterfaceTypeAttribute(Type type)
	{
		this.type = type;
	}
}
