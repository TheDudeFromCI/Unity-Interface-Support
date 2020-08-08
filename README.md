<h1 align="center">Unity Interface Support</h1>
<p align="center"><i>Unity Interface Support is a small Unity package that adds an attribute for allowing interfaces to be used on MonoBehaviours in the Unity inspector. Interfaces are fully serialized and blend seamlessly with standard Unity workflows.</i></p>

<p align="center">
  <img src="https://img.shields.io/github/license/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/repo-size/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/issues/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/v/release/Wraithaven-UnityTools/Unity-Interface-Support?include_prereleases" />
  <a href="https://openupm.com/packages/net.wraithavengames.unityinterfacesupport/"><img src="https://img.shields.io/npm/v/net.wraithavengames.unityinterfacesupport?label=openupm&registry_uri=https://package.openupm.com" /></a>
</p>

---

### Summary

This tiny Unity package allows for a user to quickly and easily add interface support to the Unity inspector.

In modern programming, proper dependency injection is essential for scaling up a project. Sadly, Unity's serializer does not currently allow for an easy implementation of interface-based components. This plugin adds a quick-and-simple approach to allowing an interface to be used within your MonoBehavior safe to assign from the editor without any fears of serialization getting in the way, or adding components of the wrong type.

### Usage

Using interfaces is as simple as adding an attribute, and writing a single property field.

Example:

```cs
// Here, we want to accept objects of the specific interface.
// The field should always be specified as a UnityEngine.Object type.
// We can now be promised that the object field will be correctly
// serialized exactly as expected. The field will always be of
// the requested interface type, or null if not assigned.
[SerializeField, InterfaceType(typeof(IMyInterface))]
private Object myObject;

// Optionally, adding a private property is recommended for
// automatically casting the object field to the interface.
private IMyInterface MyInterface => myObject as IMyInterface;


// ...

// If using the property field, you can reference the property
// directly and us it as the interface.
void Start()
{
    if (MyInterface != null)
        MyInterface.SayHi();
}
```

**Arrays**

Using arrays is nearly identical, but each element in the array must be casted individually. You can do this by using a quick getting and setter function.

```cs
[SerializeField, InterfaceType(typeof(IMyInterface))]
private Object[] myObjects;

public IMyInterface MyInterface(int index) => myObjects[index] as IMyInterface;
public IMyInterface MyInterface(int index, IMyInterface value) => myObjects[index] = value;
```

### Additional Information

You can find more information about using this Unity package by checking out the Documentation page. This page is also included in local installations within the UnityInterfaceSupport/Documentation~ folder in your Unity Packages directory.

### Video Demo

https://www.youtube.com/watch?v=2xYdQgXGhe0
