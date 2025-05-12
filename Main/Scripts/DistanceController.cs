using UnityEngine;
using Main.Scripts.Levels;

namespace Main.Scripts
{
    public class DistanceController : MonoBehaviour
    {
        private Camera _camera;
        private Level _level;

        [SerializeField] private float maxDistance;
        [SerializeField] private int pauseTime;

        private void Start()
        {
            _camera = FindFirstObjectByType<Camera>();
            _level = GetComponent<Level>();
        }

        private void FixedUpdate() => DisplayControl();

        private void DisplayControl()
        {
            foreach (var coin in _level.coins)
                coin.gameObject.SetActive(Vector3.Distance(_camera.transform.position, coin.transform.position) <= maxDistance);
        }
    }
}