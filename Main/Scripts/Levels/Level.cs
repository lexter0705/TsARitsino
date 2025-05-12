using UnityEngine;

using Main.Scripts.Coins;

namespace Main.Scripts.Levels
{
    public abstract class Level : MonoBehaviour
    {
        public abstract void DeleteCoin(Coin coin);
        
        public abstract void SpawnCoin(Coin coin);

        public abstract Coin[] coins { get; }
    }
}