using UnityEngine;
using UnityEngine.UI;

public class CoinsPresenter : MonoBehaviour
{
    Coins coins;
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;
    private void Awake()
    {
        coins.setAmount(PlayerPrefs.GetInt("Coins", 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            draw(coins.OnPickupCoin());
    }

    private void draw(int count)
    {
        _render.text = $"Coins: {count}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", count);
    }
}
