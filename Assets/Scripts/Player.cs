using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    List<PizzaIngredientSO> currentIngredients;

    [SerializeField]
    int currentGold;

    public void AddIngredient(PizzaIngredientSO ingredient)
    {
        currentIngredients.Add(ingredient);
    }

    public void ClearIngredients()
    {
        currentIngredients.Clear();
    }


    public void AddGold(int goldToAdd)
    {
        currentGold += goldToAdd;
    }

    public void TakeGold(int goldToTake)
    {
        currentGold -= goldToTake;
    }
}
