# About Unity Interface Support

This is a very simple package which adds the "InterfaceType" attribute, to make working with interfaces in the Unity Inspector easier.

By default, Unity does not serialize fields that interfaces. Because of this, it becomes difficult to attach interfaces on the Unity Objects we're all used to. This package allows you to bypass this serialization issue through the use of a single attribute.

# Installing Unity Interface Support

To install this package, follow the instructions in the [Package Manager documentation](https://docs.unity3d.com/Packages/com.unity.package-manager-ui@latest/index.html).

# Using Unity Interface Support

When placing an interface field in the Unity inspector which you want to serialize, you simply need to add the `InterfaceType` attribute, and write the field as a `UnityEngine.Object` instead. It can then be guaranteed that the object is of the type of interface requested and can be used as such.

Full Example:

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

# Technical details

## Requirements

This package has no additional requirements.

## Package contents

This package only contains the single attribute, `InterfaceType` which exists within the default namespace.

## Document revision history

| Date         | Reason                         |
| ------------ | ------------------------------ |
| June 8, 2020 | Initial documentation written. |
