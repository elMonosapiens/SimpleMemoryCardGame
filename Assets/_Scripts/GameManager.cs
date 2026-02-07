// ----------------------------------------
// Script: GameManager.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Core
// License: MIT
// Version: 1.0.0
// Created: 2026-02-07 00:41:37
// Updated: 2026-02-07 01:05:42
// Description: [Insert Description]
// ----------------------------------------

using UnityEngine;

namespace ElMonosapiens.FlipEmCards.Core
{
    public class GameManager : MonoBehaviour
    {
        private int playerPoints = 0;
        private int cpuPoints = 0;

        public void AddPoints(bool isPlayerTurn)
        {
            if (isPlayerTurn)
                playerPoints++;
            else
                cpuPoints++;
        }
    }
}
