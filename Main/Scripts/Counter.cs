using UnityEngine;
using Main.Scripts.Ui;

namespace Main.Scripts
{
    public class Counter : MonoBehaviour
    {
        private int _count;
        private CountSetter _uiCountSetter;

        private void Start()
        {
            _uiCountSetter = FindFirstObjectByType<CountSetter>();
            LoadFromMemory();
        }

        private void LoadFromMemory()
        {
        }

        public void Add()
        {
            _count++;
            _uiCountSetter.SetTextToCount(_count);
        }
    }
}