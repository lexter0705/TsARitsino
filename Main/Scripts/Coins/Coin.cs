using Main.Scripts.Levels;
using UnityEngine;

namespace Main.Scripts.Coins
{
    public class Coin : MonoBehaviour
    {
        private Level _level;
        
        public Level level => _level;
        
        private void Awake() => _level = FindFirstObjectByType<Level>();
    }
}