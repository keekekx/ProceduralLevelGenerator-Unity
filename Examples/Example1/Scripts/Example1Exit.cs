﻿using ProceduralLevelGenerator.Unity.Examples.Common;
using UnityEngine;

namespace ProceduralLevelGenerator.Unity.Examples.Example1.Scripts
{
    /// <summary>
    /// Example implementation of an exit is activated by pressing E and loads the next level.
    /// </summary>
    public class Example1Exit : InteractableBase
    {
        public override void BeginInteract()
        {
            ShowText("Press E to exit the level");
        }

        public override void Interact()
        {
            if (Input.GetKey(KeyCode.E))
            {
                Example1GameManager.Instance.LoadNextLevel();
            }
        }

        public override void EndInteract()
        {
            HideText();
        }
    }
}