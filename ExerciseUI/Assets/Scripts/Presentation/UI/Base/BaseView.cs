using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ExerciseUI.Presentation.UI.Base
{
    public class BaseView : MonoBehaviour
    {
        public event Action Clicked;

        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private TextMeshProUGUI _text;

        [SerializeField] private RectTransform _inventoryItemsPanel;

        [SerializeField] private Button _button;

        private void Start()
        {
            _button.interactable = true;
            _button.onClick.AddListener(() => Clicked?.Invoke());
        }

        public void SetTitle(string title)
        {
            _title.SetText(title);
        }

        public void SetText(string text)
        {
            _text.SetText(text);
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject?.SetActive(false);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveAllListeners();

            Clicked = null;
        }
    }
}