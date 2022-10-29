using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PizzaRecipe", menuName = "Game/Pizza Recipe")]
public class PizzaRecipeSO : ScriptableObject
{
    [SerializeField]
    string pizzaName;

    public string PizzaName { get => pizzaName; }

    [SerializeField]
    List<PizzaIngredientSO> ingredients;

    public List<PizzaIngredientSO> Ingredients { get => ingredients; }
}
