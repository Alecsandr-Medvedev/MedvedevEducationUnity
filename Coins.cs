public class Coins
{
    
    private int _amount = 0;

    public int OnPickupCoin()
    {
        _amount++;
        return _amount;
    }

    public bool TryDiscard(int price)
    {
        if (_amount < price)
            return false;

        _amount -= price;
        return true;
    }

    public void setAmount(int amount)
    {
        if (amount > 0)
        {
            _amount = amount;
        }
    }
}
