using ExerciseUI.Presentation.Controllers;
using ExerciseUI.Presentation.Controllers.Inventory;
using ExerciseUI.Presentation.UI.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ExerciseUI.App
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private BaseView _inventoryView;

        [SerializeField] private Button _openInvectoryUI;
        [SerializeField] private TextMeshProUGUI _numberElementsField;

        private InventoryController _inventoryController;

        private void Start()
        {
            _inventoryController = new InventoryController(_inventoryView);
            var mainMenuController = new MainMenuController(_inventoryController);

            _openInvectoryUI.onClick.AddListener(ShowInventory);
        }

        public void ShowInventory()
        {
            //_inventoryController.ShowInventory();
            // открытие общего примера (доб. в него 2 части)
        }

        private void OnDestroy()
        {
            _openInvectoryUI.onClick.RemoveAllListeners();
        }
    }
}