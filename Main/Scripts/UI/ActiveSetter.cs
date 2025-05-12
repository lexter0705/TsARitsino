using UnityEngine;

namespace Main.Scripts.Ui
{
    public class ActiveSetter : MonoBehaviour
    {
        private bool _isActive;

        private void Awake()
        {
            _isActive = gameObject.activeSelf;
        }

        public void SetActive()
        {
            _isActive = !_isActive;
            gameObject.SetActive(_isActive);
            Debug.Log(_isActive);
        }
    }
}