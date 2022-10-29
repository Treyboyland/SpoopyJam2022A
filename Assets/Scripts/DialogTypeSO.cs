using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogType", menuName = "Game/Dialog Type")]
public class DialogTypeSO : ScriptableObject
{
    [SerializeField]
    string typeName;

    public string TypeName { get => typeName; }
}
