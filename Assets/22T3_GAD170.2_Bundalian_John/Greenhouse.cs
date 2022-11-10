using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JohnBundalian
{
    public enum Herbs { Undefined, BlackLotus, Dreamfoil, Earthroot, Fadeleaf, Firebloom, Goldthorn, GhostMushroom, Liferoot, KingsBlood, PeaceBloom };

    public class Greenhouse : MonoBehaviour
    {
        private int plantValue;
        private float plantHealthiness;
        public GameObject plant;
        private int plantcount;
        private GameObject[] totalplants = new GameObject[10];
        Herbs myPlant;
        

        public void Start()
        {
            if (plantcount < 10)
            {
                totalplants[plantcount] = plant;
                plantcount++;
            }
                      
            // Randomies Plants Value
            plantValue = UnityEngine.Random.Range(1, 21);
            // Randomises Plants health.
            plantHealthiness = UnityEngine.Random.Range(1, 101);         
            myPlant = Herbs.BlackLotus;
            myPlant = (Herbs)UnityEngine.Random.Range(0, 3);
            
            // myPlant = (Herbs)UnityEngine.Random.Range(0, Enum.GetValues(typeof(Herbs)).Cast<Herbs>().Max);
            // :D all good thats just another Gamer dude outside SAE who I reached out too
        }

        public void NewGame()
        {

        }
        

        // Starts Players turn.
        public void NewTurn()
        {

         // Puts value into plan var detects what put in (notes for Learning Journal Thank you!)
            var plantObject = Instantiate(plant, transform.position, transform.rotation);
            plantObject.GetComponent<Plant>().SetInitialStats(null,myPlant, plantHealthiness,plantValue);
            plant = plantObject;
            // Instantiate new plant gameobject
            // Set new plant variables.
            // Player givens options Keep or Discard new plant.
            // Player click Keep or discard button.
        }

        // Ends a Player turn.
        public void EndTurn()
        {
            //
            // Else if objectDestroy
        }

        // Game ends.
        private void Gameover()
        {

        }

        public void MainMenu()
        {
            Debug.Log("Game goes to Main Menu");
        }

        public void KeepPlant()
        {
            Debug.Log("Keep Plant");
        }

        public void DiscardPlant()
        {
            Debug.Log("Plant Discarded");
        }

        // yeah i put those in while i trying to figure out the buttons on text thingy
        // like on debug log only


    }
}

