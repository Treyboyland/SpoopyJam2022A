using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaOven : MonoBehaviour
{
    [SerializeField]
    List<PizzaRecipeSO> potentialRecipes;

    List<PizzaRecipeSO> currentRecipes;

    [SerializeField]
    float timeMultiplier;

    float currentTime;

    public bool CanCook { get => currentTime != 0 && !IsCooking; }

    public bool IsCooking { get; } = false;


    // Start is called before the first frame update
    void Start()
    {
        currentRecipes = potentialRecipes;
    }

    private void Update()
    {
        currentTime -= timeMultiplier * Time.deltaTime;

        if (currentTime < 0)
        {
            currentTime = 0;
        }
    }

    public void AddTime(float timeToAdd)
    {
        currentTime += timeToAdd;
    }



}
