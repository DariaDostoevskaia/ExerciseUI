using UnityEngine;

namespace ExerciseUI.ScriptalObjects
{
    [CreateAssetMenu(fileName = nameof(InventorySO), menuName = "Config/InventorySO")]
    public class InventorySO : ScriptableObject
    {
        [SerializeField] private string _title;
        [SerializeField] private string _text;

        [SerializeField] private int _count = 1;

        public int JumpLenght => _count;
    }
}