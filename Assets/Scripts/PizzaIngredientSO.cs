using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PizzaIngredient-", menuName = "Game/Ingredient")]
public class PizzaIngredientSO : ScriptableObject
{
    [SerializeField]
    string ingredientName;

    public string IngredientName { get => ingredientName; }
}
