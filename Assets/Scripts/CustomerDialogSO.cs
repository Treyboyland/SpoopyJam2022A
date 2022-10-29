using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Customer Dialog", menuName = "Game/Customer")]
public class CustomerDialogSO : ScriptableObject
{

    [TextArea]
    [SerializeField]
    string characterDialog;

    public string CharacterDialog { get => characterDialog; }
}
