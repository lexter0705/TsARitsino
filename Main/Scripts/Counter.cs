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
            _uiCountSetter.SetTextToCount(_count);
        }

        private void LoadFromMemory()
        {
            _count = PlayerPrefs.GetInt(nameof(_count));
            if (_count == 0)
                PlayerPrefs.SetInt(nameof(_count), 0);
        }

        public void Add()
        {
            _count++;
            PlayerPrefs.SetInt(nameof(_count), _count);
            _uiCountSetter.SetTextToCount(_count);
        }
    }
}