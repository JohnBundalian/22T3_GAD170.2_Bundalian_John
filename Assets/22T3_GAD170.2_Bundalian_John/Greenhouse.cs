using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JohnBundalian
{
    public enum Herbs { Undefined, BlackLotus, Dreamfoil, Earthroot, Fadeleaf, Firebloom, Goldthorn, GhostMushroom, Liferoot, KingsBlood, PeaceBloom };

    public class Greenhouse : MonoBehaviour
    {

        void Start()
        {
            Herbs myPlant;

            myPlant = Herbs.BlackLotus;
        }

        // Player will starts a fresh new game.
        public void NewGame()
        {

        }

        // Starts Players turn.
        public void NewTurn()
        {
// Instantiate new plant gameobject
// Set new plant variables.
// Player givens options Keep or Discard new plant.
// Player click Keep or discard button.
        }

        // Ends a Player turn.
        public void EndTurn()
        {

        }

        // Game ends.
        private void Gameover()
        {

        }

        public void KeepPlant()
        {
            Debug.Log("Keep Plant");
        }
    }
}

