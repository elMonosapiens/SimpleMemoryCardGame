// ----------------------------------------
// Script: CardUtility.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Gameplay
// Copyright © 2026 elMonosapiens Games. All rights reserved.
// Version: 1.0.0
// Created: 2026-02-07 01:21:29
// Updated: 2026-02-07 01:36:52
// Description: [Insert Description]
// ----------------------------------------

using System.Collections.Generic;
using ElMonosapiens.FlipEmCards.Core;
using UnityEngine;

namespace ElMonosapiens.FlipEmCards.Gameplay
{
    public static class CardUtility
    {
        public static List<CardData> CreateCardPairs(CardData[] dataArray)
        {
            List<CardData> cardPairs = new();

            for (int i = 0; i < dataArray.Length; i++)
            {
                cardPairs.Add(dataArray[i]);
                cardPairs.Add(dataArray[i]);
            }

            return cardPairs;
        }

        public static void ShuffleCards(Card[] cards, CardData[] dataArray)
        {
            int[] array = new int[cards.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = Random.Range(0, array.Length);
                (array[randomNumber], array[i]) = (array[i], array[randomNumber]);
            }

            for (int i = 0; i < dataArray.Length; i++)
            {
                cards[array[i]].SetData(dataArray[i]);
            }
        }
    }
}
