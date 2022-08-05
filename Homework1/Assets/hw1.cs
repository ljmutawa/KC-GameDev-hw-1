using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hw1 : MonoBehaviour
{
    string hero;
    int health = 100;
    int damagedHealth;
    int boostedHealth;


    // Start is called before the first frame update
    void Start()
    {
        Damaged();
        Boost();
        CompareValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Damaged()
    {
       damagedHealth = health - 20;
       print("Damaged health = " + damagedHealth);
    }

    void Boost()
    {
        boostedHealth = damagedHealth + 10;
        print("Boosted health = " + boostedHealth);
    }

    //output seems right bas something feels off with having three health variables

    void CompareValues()
    {
        if (damagedHealth > boostedHealth)
        {
            print(damagedHealth + " is greater than " + boostedHealth);
        }
        else if (damagedHealth < boostedHealth)
        {
            print(damagedHealth + " is less than " + boostedHealth);
        }
        else
        {
            print("both values are equal");
        }
    }
}
