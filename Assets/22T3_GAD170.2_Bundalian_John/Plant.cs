using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public class Plant : MonoBehaviour
    {
        private string name;
        private Herbs species = Herbs.Undefined;
        private int healthiness;
        private int price;

        void Start()
        {
            Herbs myPlant;

            myPlant = Herbs.BlackLotus;
        }
        //Variables:
        public int GetHealthiness()
        {
            return healthiness;
        }

        public void SetInitialStats(string newName, Herbs newHerbs, int newHealthiness, int newPrice)
        {
            name = newName;
            species = newHerbs;
            healthiness = newHealthiness;
            price = newPrice;

           // newHerbs.herbsName = Herbs[UnityEngine.Random.Range(0, HerbsNames.Count())];
             //   newHealthiness.maxHealth = Random.Range(1, 10);
           // newPrice.maxPrice = Random.Range(1, 20);
        }

    }
}


