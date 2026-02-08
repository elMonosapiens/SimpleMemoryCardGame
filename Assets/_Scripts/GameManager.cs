// ----------------------------------------
// Script: GameManager.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Core
// License: MIT
// Version: 1.0.0
// Created: 2026-02-07 00:41:37
// Updated: 2026-02-08 02:45:49
// Description: [Insert Description]
// ----------------------------------------

using System;
using UnityEngine;
using ElMonosapiens.FlipEmCards.UI;

namespace ElMonosapiens.FlipEmCards.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private GameUI gameUI;

        public event Action OnGameStarted;

        private void Awake()
        {
            MakethSingleton();
        }

        private void Start()
        {
            OnGameStarted?.Invoke();
        }

        private void MakethSingleton()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            Instance = this;
        }

        public void UpdateScore(int player, int cpu)
        {

        }

        public void DisplayResults()
        {

        }
    }
}
