namespace Main.Scripts.Coins
{
    public class TsaritsinoCoin : Coin
    {
        private Counter _counter;
        
        private void Start() => _counter = FindFirstObjectByType<Counter>();

        private void OnMouseEnter()
        {
            _counter.Add();
            level.DeleteCoin(gameObject.GetComponent<TsaritsinoCoin>());
        }
    }
}