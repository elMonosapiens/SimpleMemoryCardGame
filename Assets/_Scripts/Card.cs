// ----------------------------------------
// Script: Card.cs
// Author: elMonosapiens
// Project: ElMonosapiens.FlipEmCards
// Module: Gameplay
// License: MIT
// Version: 1.0.0
// Created: 2026-02-06 21:53:32
// Updated: 2026-02-07 01:51:29
// Description: [Insert Description]
// ----------------------------------------

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using ElMonosapiens.FlipEmCards.Core;


namespace ElMonosapiens.FlipEmCards.Gameplay
{
    public class Card : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private Sprite backSprite;
        [SerializeField] private TextMeshProUGUI matchOwnerText;

        public string Label => data.label;
        public bool IsFaceUp { get; private set; }

        private TableManager cardController;
        private CardData data;
        private Button button;
        private Image image;

        private void Awake()
        {
            button = GetComponent<Button>();
            image = GetComponent<Image>();

            button.onClick.AddListener(OnClicked);
        }

        public void SetData(CardData newData) => data = newData;
        public void SetInteractable(bool isEnabled) => button.interactable = isEnabled;

        public void Initialize(TableManager controller)
        {
            cardController = controller;

            IsFaceUp = false;
            image.sprite = backSprite;
        }

        private void OnClicked()
        {
            //cardController.FlipCard(this);
        }
    }
}
