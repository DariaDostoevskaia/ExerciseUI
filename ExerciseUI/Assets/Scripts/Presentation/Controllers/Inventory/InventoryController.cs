using ExerciseUI.Presentation.UI.Base;

namespace ExerciseUI.Presentation.Controllers.Inventory
{
    public class InventoryController
    {
        private BaseView _inventoryView;

        public InventoryController(BaseView inventoryView)
        {
            _inventoryView = inventoryView;
        }

        //public void ShowInventory()
        //{
        //    _inventoryView.Show();
        //}

        //public void CloseInventory()
        //{
        //    _inventoryView?.Close();
        //}
    }
}