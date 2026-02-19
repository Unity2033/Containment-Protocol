using UnityEngine;
using Photon.Pun;

public class LobbyManager : MonoBehaviourPunCallbacks
{

    public override void OnConnectedToMaster()
    {
        // JoinLobby : 특정 로비를 생성하여 진입하는 함수
        if(PhotonNetwork.InLobby == false)
        {
            PhotonNetwork.JoinLobby();
        }
    }

}
