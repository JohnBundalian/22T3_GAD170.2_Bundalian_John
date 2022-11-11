using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace JohnBundalian
{

    public class Greenhouse : MonoBehaviour
    {
        private int turnsCount = 0;
        private float score = 0;
        // Is the collection of names of associated plants that can be referred to.
        // Herbs is now an array of strings.
        // Creating an Array as we are only getting information, don't need to change information.
        public string[] herbs = new string[] { "BlackLotus", "Dreamfoil", "Earthroot", "Fadeleaf", "Firebloom", "Goldthorn", "GhostMushroom", "Liferoot", "KingsBlood", "PeaceBloom" };
        // List is used for total plants as we need to be able to read information from it, change it size, adds alot of functionality to read information about it.
        private List<plant> totalplants = new List<plants>();

        // $ cost of the Plant.
        //*** private int plantValue;
        // Health condition of the plant that impacts the $ value of the plant.
        //*** private float plantHealthiness;
        // Plants generate an object to interact with the space.
        //*** public GameObject plant;
        // Collection of Plant objects to be counted to comply to Brief Spec.
        //*** public int plantcount;
        // Creates an Array that holds 10 new gameobjects.
        //*** private GameObject[] totalplants = new GameObject[10];
        //*** Herbs myPlant;


        public void Start()
        {
            // If condition that player keeps Plant exceeds the inventory of 10 plants it will replace plant to comply with mechanics.
            //***  if (plantcount < 10)
            //*** {
            //*** totalplants[plantcount] = plant;
            //*** plantcount++;
            //*** }

            // Randomies Plants Value
            //*** plantValue = UnityEngine.Random.Range(1, 21);
            // Randomises Plants health.
            //*** plantHealthiness = UnityEngine.Random.Range(1, 101);         
            //*** myPlant = Herbs.BlackLotus;
            // Randomises selection from the varriety of plant spieces?
            //*** myPlant = (Herbs)UnityEngine.Random.Range(0, 11);

            // myPlant = (Herbs)UnityEngine.Random.Range(0, Enum.GetValues(typeof(Herbs)).Cast<Herbs>().Max);
            // :D all good thats just another Gamer dude outside SAE who I reached out too
        }

        // Player starts a new game.
        public void NewGame()
        {
            // Clear out the old green house and restart code.
            // reset the turn counter to o.
            // Reset Code to 00
            Debug.Log("New Game");
        }


        // Starts Players turn.
        public void NewTurn()
        {
            // Puts value into plan var detects what put in.
            //*** var plantObject = Instantiate(plant, transform.position, transform.rotation);
            //*** plantObject.GetComponent<Plant>().SetInitialStats(null,myPlant, plantHealthiness,plantValue);
            //*** plant = plantObject;
            // Instantiate new plant gameobject
            // Set new plant variables.
            // Player givens options Keep or Discard new plant.
            // Player click Keep or discard button.
        }

        // Ends a Player turn.
        public void EndTurn()
        {
            // Else if objectDestroy
            Debug.Log("Game end turn");

            // Display the Stat for the current Greenhouse Plants,
            // If turncount = 20, end the game.
            // else, turn count +=1

        }

        // Game ends.
        private void Gameover()
        {
            Debug.Log("Gameover");
            // Display All Garden Stats
            // Sum the scores and Displace
            // Return to main menu
        }

        // Player closes game and takes it back to Main Menu.
        public void MainMenu()
        {
            Debug.Log("Game goes to Main Menu");
        }

        public void NewPlant()
        {
            private Plant newPlant = new Plant();
            return newPlant.RandomisePlant();
        }

    // Player choice to keep the presented Plant to store in Garden.
    public void KeepPlant(Plant newPlant)
    {
        totalplants.Add(newPlant);
        Debug.Log("Keep Plant");
    }

    // Players choice to discard presented Plant.
    public void DiscardPlant(Plant newPlant)
    {
        Destroy(newPlant);
        Debug.Log("Plant Discarded");
    }
    public void displayGreenhouse()
    {

    }

    public int getWorstPlant()
        // float lowest healt = 100
        // int lowestIndex = 0
        // for all in totalplants{
        // if health < lowest health
        // lowesthealth = health
        // lowestindex = i
        // }
        // }
        // returns lowest index
        //.

}
       
