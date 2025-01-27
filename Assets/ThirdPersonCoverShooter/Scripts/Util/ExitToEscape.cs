﻿using UnityEngine;

namespace CoverShooter
{
    /// <summary>
    /// Exits the game when an escape key is pressed.
    /// </summary>
    public class ExitToEscape : MonoBehaviour
    {
        private void LateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Application.Quit();
        }
    }
}