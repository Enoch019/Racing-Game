using UnityEngine;
using Photon.Pun; 

public class AddHp : MonoBehaviourPunCallbacks
{
    private PlayerHp _playerHp; 
    public float Amount = 0;
    public bool Destroiable = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PhotonView>().RPC("AddOrMinusHp" , RpcTarget.All , Amount);
            
            if (Destroiable)
            {
                PhotonNetwork.Destroy(gameObject);
            }
        }
    }
}
