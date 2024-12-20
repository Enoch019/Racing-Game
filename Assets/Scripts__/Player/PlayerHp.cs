using System.Collections.Generic;
using UnityEngine;
using Photon.Pun; 

public class PlayerHp : MonoBehaviourPunCallbacks
{
    [Header("Hp Setting")]
    public float Hp = 10.0f;

    public List<Sprite> Sprites = new List<Sprite>(); 

    [PunRPC]
    public void AddOrMinusHp(float hp)
    {
        Hp += hp;
        if (Hp > 10)
            Hp = 10; 
    }
}
