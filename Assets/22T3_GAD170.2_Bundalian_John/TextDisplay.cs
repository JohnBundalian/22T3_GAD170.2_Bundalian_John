using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace JohnBundalian
{
    public class UserInterface : MonoBehaviour
    {
        Herbs myPlant;

        //This method adds text to what is present.
        // In the text field UI.
        private void AddText(string textToAdd)
        {

        }

        // Empties the text field.
        // Reset an int to zero-assign it a value of " "
        private void ClearText()
        {

        }

        // Clears the text field, prints an error
        // prevents any furuther text from being added
        private void Problems(string errorReport)
        {
            myPlant.Addtext("you gained one plant");
        }
    }
}

