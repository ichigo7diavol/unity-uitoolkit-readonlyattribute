using MergeRunner.Features.ReadOnlyInspector.Attributes;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MergeRunner.Features.ReadOnlyInspector.Editor
{
    [CustomPropertyDrawer(typeof(ReadOnlyInspectorAttribute))]
    public class ReadOnlyInspectorAttributeDrawer
        : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            var field = new PropertyField(property);            
            
            field.SetEnabled(false);
            
            return field;
        }
    }
}