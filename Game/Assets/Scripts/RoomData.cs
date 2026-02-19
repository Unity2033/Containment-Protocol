using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;

public class RoomData : MonoBehaviourPunCallbacks
{
    [SerializeField] Text roomText;

    [SerializeField] Button button;

    [SerializeField] string titleText;

    private void Start()
    {
        button.onClick.AddListener(() => PhotonNetwork.JoinRoom(titleText));
    }

    public void UpdateRoomInformation(RoomInfo roomInfo)
    {
        titleText = roomInfo.Name;

        roomText.text = roomInfo.Name + " ( " + roomInfo.PlayerCount + " / " + roomInfo.MaxPlayers + " ) ";
    }

}
