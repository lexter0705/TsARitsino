using UnityEngine;

namespace Main.Scripts.Coins
{
    public class TsaritsinoCoin : Coin
    {
        private Counter _counter;

        [SerializeField] private float distance;

        private void Start() => _counter = FindFirstObjectByType<Counter>();

        private void OnMouseDown()
        {
            _counter.Add();
            level.DeleteCoin(this);
        }
    }
}