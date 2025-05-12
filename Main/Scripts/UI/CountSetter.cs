using TMPro;
using UnityEngine;

namespace Main.Scripts.Ui
{
    public class CountSetter : MonoBehaviour
    {
        private TextMeshProUGUI _text;

        private void Start() => _text = GetComponent<TextMeshProUGUI>();

        public void SetTextToCount(int newCount)
        {
            if (newCount >= 0)
                _text.text = "" + newCount;
        }
    }
}
