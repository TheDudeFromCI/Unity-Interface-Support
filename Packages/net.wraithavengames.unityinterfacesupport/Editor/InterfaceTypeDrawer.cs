using UnityEngine;
using UnityEditor;

namespace WraithavenGames.UnityInterfaceSupport
{
    /// <summary>
    /// This property drawer is the meat of the interface support implementation. When
    /// the value of field with this attribute is modified, the new value is tested
    /// against the interface expected. If the component matches, the new value is
    /// accepted. Otherwise, the old value is maintained.
    /// </summary>
    [CustomPropertyDrawer(typeof(InterfaceTypeAttribute))]
    public class InterfaceTypeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            InterfaceTypeAttribute att = attribute as InterfaceTypeAttribute;

            if (property.propertyType != SerializedPropertyType.ObjectReference)
            {
                EditorGUI.LabelField(position, label.text, "InterfaceType Attribute can only be used with MonoBehaviour Components!");
                return;
            }

            // Pick a specific component
            MonoBehaviour oldComp = property.objectReferenceValue as MonoBehaviour;

            GameObject temp = null;
            string oldName = "";

            if (Event.current.type == EventType.Repaint)
            {
                if (oldComp == null)
                {
                    temp = new GameObject("None [" + att.type.Name + "]");
                    oldComp = temp.AddComponent<MonoInterface>();
                }
                else
                {
                    oldName = oldComp.name;
                    oldComp.name = oldName + " [" + att.type.Name + "]";
                }
            }

            MonoBehaviour comp = EditorGUI.ObjectField(position, label, oldComp, typeof(MonoBehaviour), true) as MonoBehaviour;

            if (Event.current.type == EventType.Repaint)
            {
                if (temp != null)
                    GameObject.DestroyImmediate(temp);
                else
                    oldComp.name = oldName;
            }

            // Make sure something changed.
            if (oldComp == comp) return;

            // If a component is assigned, make sure it is the interface we are looking for.
            if (comp != null)
            {
                // Make sure component is of the right interface
                if (comp.GetType() != att.type)
                    // Component failed. Check game object.
                    comp = comp.gameObject.GetComponent(att.type) as MonoBehaviour;

                // Item failed test. Do not override old component
                if (comp == null) return;
            }

            property.objectReferenceValue = comp;
            property.serializedObject.ApplyModifiedProperties();
        }
    }

    public class MonoInterface : MonoBehaviour
    {
    }
}
