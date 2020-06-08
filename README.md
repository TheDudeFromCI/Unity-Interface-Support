<h1 align="center">Unity Interface Support</h1>
<p align="center"><i>A small Unity package which adds a simple attribute which allows for usage of interfaces on MonoBehaviours in the Unity inspector. Interfaces are fully serialized and blend seamlessly with standard Unity workflows.</i></p>

<p align="center">
  <img src="https://img.shields.io/github/license/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/repo-size/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/issues/Wraithaven-UnityTools/Unity-Interface-Support" />
  <img src="https://img.shields.io/github/v/release/Wraithaven-UnityTools/Unity-Interface-Support?include_prereleases" />
  <a href="https://openupm.com/packages/net.wraithavengames.unityinterfacesupport/"><img src="https://img.shields.io/npm/v/net.wraithavengames.unityinterfacesupport?label=openupm&registry_uri=https://package.openupm.com" /></a>
</p>

---

<h2 align="center">A Super Special Thanks To</h2>
<p align="center">
  :star: Mika, Alora Brown :star:
</p>

<br />

<h3 align="center">And a Warm Thank You To</h3>
<p align="center">
  :rocket:  :rocket:
</p>

<br />
<br />

Thank you all for supporting me and helping this project to continue being developed.

<br />

<p>Want to support this project?</p>
<a href="https://www.patreon.com/thedudefromci"><img src="https://c5.patreon.com/external/logo/become_a_patron_button@2x.png" width="150px" /></a>
<a href='https://ko-fi.com/P5P31SKR9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi2.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

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

### Additional Information

You can find more information about using this Unity package by checking out the Documentation page. This page is also included in local installations within the UnityInterfaceSupport/Documentation~ folder in your Unity Packages directory.

### Video Demo

https://www.youtube.com/watch?v=2xYdQgXGhe0
