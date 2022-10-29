using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterCreator2D;

[CreateAssetMenu(fileName = "CustomerRandomizer", menuName = "Game/Customer Randomizer")]
public class CustomerRandomizerSO : ScriptableObject
{
    [SerializeField]
    List<Part> possibleParts;

    Dictionary<PartCategory, List<Part>> partsByCategory;

    private void OnEnable()
    {
        partsByCategory = new Dictionary<PartCategory, List<Part>>();

        foreach (var part in possibleParts)
        {
            if (!partsByCategory.ContainsKey(part.category))
            {
                partsByCategory.Add(part.category, new List<Part>());
            }
            partsByCategory[part.category].Add(part);
        }
    }

    public void RandomizeCharacter(Customer customer)
    {
        RandomizeCharacter(customer.Character);
    }

    public void RandomizeCharacter(CharacterViewer character)
    {
        foreach (var keyVal in partsByCategory)
        {
            var category = keyVal.Key;
            int index = Random.Range(0, keyVal.Value.Count);
            var part = keyVal.Value[index];
            character.EquipPart((SlotCategory)category, "");
            character.EquipPart((SlotCategory)category, part);
        }
    }
}
