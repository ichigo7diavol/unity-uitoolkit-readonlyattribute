using System;
using UnityEngine;

namespace MergeRunner.Features.ReadOnlyInspector.Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ReadOnlyInspectorAttribute
        : PropertyAttribute
    {
    }
}