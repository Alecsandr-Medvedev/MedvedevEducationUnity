using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeRoot : MonoBehaviour
{
    private Coins _coins;
    private void Awake()
    {
        _coins.setAmount(PlayerPrefs.GetInt("Coins", 0));
    }

}
