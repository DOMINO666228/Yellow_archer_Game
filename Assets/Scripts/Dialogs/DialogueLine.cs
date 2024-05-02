using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;

        [Header ("Text options")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor;
        [SerializeField] private Font textFont;

        [Header("Time parameters")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        [Header("Character Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image ImageHolder;
        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";

            ImageHolder.sprite = characterSprite;
            ImageHolder.preserveAspect = true;
        }
        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, delayBetweenLines));
        }
    }
}

