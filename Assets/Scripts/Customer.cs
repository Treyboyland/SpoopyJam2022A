using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterCreator2D;

public class Customer : MonoBehaviour
{
    [SerializeField]
    CharacterViewer character;

    [SerializeField]
    CustomerRandomizerSO customerRandomizer;

    public CharacterViewer Character { get => character; }

    public PizzaRecipeSO CurrentOrder { get; set; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RandomizeCustomer(CustomerRandomizerSO randomizerSO)
    {
        randomizerSO.RandomizeCharacter(this);
    }

    public void RandomizeCustomer()
    {
        customerRandomizer.RandomizeCharacter(this);
    }
}
