using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TalkTrainer.Logic
{
    using NaughtyAttributes;

    public class ImageNumber : MonoBehaviour
    {
         
        [ReorderableList]
        [SerializeField]
        protected Image[] images;   // Display Image

        [ReorderableList]
        [SerializeField]
        protected Sprite[] spriteDigits;    // sprite number (0-9)

        // Use this for initialization
        void Start()
        {
            BoardController.instance.onChangedMineNumber += OnUpdateNumber;
        }

        // Update is called once per frame
        void OnUpdateNumber()
        {
            UpdateNumber(BoardController.instance.RestMine);
        }

        void UpdateNumber(int num) 
        {
            int digit = 0;
            for (int i = 0; i < images.Length;++i) {
                digit = num % 10;
                images[i].sprite = spriteDigits[digit];
                num /= 10;
            }
        }
    }

}