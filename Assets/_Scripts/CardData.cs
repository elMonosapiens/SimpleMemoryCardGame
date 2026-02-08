// ----------------------------------------
// Script: CardData.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Gameplay
// License: MIT
// Version: 1.0.0
// Created: 2026-02-06 21:59:52
// Updated: 2026-02-07 21:16:22
// Description: [Insert Description]
// ----------------------------------------

using UnityEngine;

namespace ElMonosapiens.FlipEmCards.Core
{
    [CreateAssetMenu(fileName = "New Card Data", menuName = "ScriptableObject/Card")]
    public class CardData : ScriptableObject
    {
        public string Label;
        public Sprite Artwork;
    }
}
