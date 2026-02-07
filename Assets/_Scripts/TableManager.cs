// ----------------------------------------
// Script: TableManager.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Gameplay
// License: MIT
// Version: 1.0.0
// Created: 2026-02-07 00:31:17
// Updated: 2026-02-07 01:51:15
// Description: [Insert Description]
// ----------------------------------------

using System.Collections.Generic;
using UnityEngine;
using ElMonosapiens.FlipEmCards.Core;
using ElMonosapiens.FlipEmCards.UI;

namespace ElMonosapiens.FlipEmCards.Gameplay
{
    public class TableManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private GameManager gameManager;

        [Header("Cards")]
        [SerializeField] private Card[] cardArray;
        [SerializeField] private CardData[] cardDataArray;

        public bool IsPlayerTurn { get; private set; }
        public int FlipCardsCount { get; private set; }

        public IReadOnlyList<Card> FacedDownCards => facedDownCards;
        private readonly List<Card> facedDownCards = new();

        private Card firstCard;
        private Card secondCard;

        private bool isAllowedToFlipCards;
        private int playerPoints = 0;
        private int cpuPoints = 0;

        private void Awake()
        {
            if (!gameManager) gameManager = FindFirstObjectByType<GameManager>();
        }

        private void StartGame()
        {
            playerPoints = cpuPoints = 0;
            IsPlayerTurn = true;

            SetupDeck();
            StartTurn(true);
        }

        private void SetupDeck()
        {
            // 1. Create pair of the card data
            var deck = CardUtility.CreateCardPairs(cardDataArray);

            // 2. Shuffle and apply
            CardUtility.ShuffleCards(cardArray, deck.ToArray());

            foreach (var card in cardArray)
            {
                card.SetInteractable(true);
                card.Initialize(this);
            }

            // 3. Initialize facedDownCards
            facedDownCards.Clear();
            facedDownCards.AddRange(cardArray);
        }

        private void ListFacedDownCards()
        {
            facedDownCards.Clear();
            foreach (var card in cardArray)
            {
                if (!card.IsFaceUp) facedDownCards.Add(card);
            }
        }

        private void StartTurn(bool isPlayerTurn)
        {
            // Announce turn start
        }

        private void ChangeTurn()
        {
            IsPlayerTurn = !IsPlayerTurn;
            StartTurn(IsPlayerTurn);
        }

        private void EndTurn()
        {

        }

    }
}
