using UnityEngine;

namespace Main.Scripts.Ui
{
    public class MenuButtonClicker : MonoBehaviour
    {
        private ActiveSetter _activeSetter;

        private void Start() => _activeSetter = FindFirstObjectByType<ActiveSetter>();

        private void OnMouseOver() => _activeSetter.SetActive();
    }
}