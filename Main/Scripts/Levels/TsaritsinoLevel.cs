using Main.Scripts.Coins;
using System.Collections.Generic;

namespace Main.Scripts.Levels
{
    public class TsaritsinoLevel : Level
    {
        private List<Coin> _coins;
        
        public override Coin[] coins => _coins.ToArray();
        
        private void Start() => SpawnCoins();

        private void SpawnCoins() => _coins = new List<Coin>(GetComponentsInChildren<Coin>());
        
        public override void DeleteCoin(Coin coin)
        {
            _coins.Remove(coin);
            Destroy(coin.gameObject);
        }

        public override void SpawnCoin(Coin coin)
        {
            _coins.Add(coin);
            Instantiate(coin.gameObject, coin.transform.position, coin.transform.rotation);
        }
    }
}