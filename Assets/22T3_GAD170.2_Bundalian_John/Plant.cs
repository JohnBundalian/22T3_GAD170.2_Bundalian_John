using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Plant : MonoBehaviour
    {
        private string name;
        private Herbs species = Herbs.Undefined;
        private float healthiness;
        private int price;

        void Start()
        {
            Herbs myPlant;

            myPlant = Herbs.BlackLotus;
        }
        //Variables:
        public float GetHealthiness()
        {
            
            return healthiness;
        }

        public void SetInitialStats(string newName, Herbs newHerbs, float newHealthiness, int newPrice)
        {
            name = newName;
            species = newHerbs;
            healthiness = newHealthiness;
            price = newPrice;
            
           // newHerbs.herbsName = Herbs[UnityEngine.Random.Range(0, HerbsNames.Count())];
             //   newHealthiness.maxHealth = Random.Range(1, 10);
           // newPrice.maxPrice = Random.Range(1, 20);
        }

        public Plant RandomisePlant()
        {
            name = newName;
            healthiness = Random.Range(1, 10);
            price = Random.Range(1, 10);
        }

        public void DisplayStats()
        {
            // Print Name
            // Print Health
            // Print Price
        }

    }
}


